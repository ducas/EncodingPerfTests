using System.Text;

namespace EncodingPerfTests.UTF8.GetByteCount
{
    class With100KChar : BaseTest
    {
        private readonly string _text;

        public With100KChar()
        {
            _text = UglyThings.GenerateText(100000);
        }

        protected override void OnRun()
        {
            Encoding.UTF8.GetByteCount(_text);
        }

        protected override string Name => "GetByteCount with 100K character values";
        protected override int Iterations => 100000; //100K
    }
}