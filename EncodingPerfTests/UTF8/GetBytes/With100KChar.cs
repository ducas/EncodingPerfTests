using System.Text;

namespace EncodingPerfTests.UTF8.GetBytes
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
            Encoding.UTF8.GetBytes(_text);
        }

        protected override string Name => "GetBytes with 100K character values";
        protected override int Iterations => 100000; //100K
    }
}