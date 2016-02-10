using System.Text;

namespace EncodingPerfTests.UTF8.GetByteCount
{
    class With1KChar : BaseTest
    {
        private readonly string _text;

        public With1KChar()
        {
            _text = UglyThings.GenerateText(1000);
        }

        protected override void OnRun()
        {
            Encoding.UTF8.GetByteCount(_text);
        }

        protected override string Name => "GetByteCount with 1K character values";
        protected override int Iterations => 1000000; //1M
    }
}
