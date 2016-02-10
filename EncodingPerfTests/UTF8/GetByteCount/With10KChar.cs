using System.Text;

namespace EncodingPerfTests.UTF8.GetByteCount
{
    class With10KChar : BaseTest
    {
        private readonly string _text;

        public With10KChar()
        {
            _text = UglyThings.GenerateText(10000);
        }

        protected override void OnRun()
        {
            Encoding.UTF8.GetByteCount(_text);
        }

        protected override string Name => "GetByteCount with 10K character values";
        protected override int Iterations => 1000000; //1M
    }
}