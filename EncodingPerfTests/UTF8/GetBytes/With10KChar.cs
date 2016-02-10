using System.Text;

namespace EncodingPerfTests.UTF8.GetBytes
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
            Encoding.UTF8.GetBytes(_text);
        }

        protected override string Name => "GetBytes with 10K character values";
        protected override int Iterations => 1000000; //1M
    }
}