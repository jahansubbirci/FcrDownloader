using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FcrDownloader
{
    public class BlockTextExtractionStrategy : LocationTextExtractionStrategy
    {
        public List<TextChunk> TextChunks { get; private set; } = new List<TextChunk>();

        public override void RenderText(TextRenderInfo renderInfo)
        {
            base.RenderText(renderInfo);
            var chunk = new TextChunk(renderInfo.GetText(),
                renderInfo.GetBaseline().GetStartPoint(),
                renderInfo.GetBaseline().GetEndPoint(), renderInfo.GetSingleSpaceWidth());
            TextChunks.Add(chunk);
        }
    }

    public class TextChunk
    {
        public string Text { get; }
        public Vector Location { get; }

        public TextChunk(string text, Vector location)
        {
            Text = text;
            Location = location;
        }
    }

}
