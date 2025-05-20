using System;
using Tesseract;
using System.Drawing;
 
class Program
{
    static void Main()
    {
        // 初始化Tesseract引擎，指定语言模型路径（例如：英文）
        using (var engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
        {
            using (var img = Pix.LoadFromFile("path_to_your_image.jpg"))
            {
                using (var page = engine.Process(img))
                {
                    var text = page.GetText(); // 获取文本内容
                    var words = page.GetText().Split(' '); // 分割文本为单词
                    var wordConfidences = page.GetMeanConfidences(); // 获取每个单词的置信度
                    
                    // 获取每个单词的坐标（需要额外的步骤来解析文本区域）
                    var iterator = page.GetIterator();
                    iterator.Begin();
                    do
                    {
                        if (iterator.TryGetSymbol(out Tesseract.TextSymbol symbol))
                        {
                            Console.WriteLine($"Word: {symbol.Text}, Bounding Box: ({symbol.BoundingBox.Left}, {symbol.BoundingBox.Top}, {symbol.BoundingBox.Width}, {symbol.BoundingBox.Height})");
                        }
                    } while (iterator.Next(out _));
                }
            }
        }
    }
}