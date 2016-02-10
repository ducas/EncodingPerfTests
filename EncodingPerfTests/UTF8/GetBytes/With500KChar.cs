using System.Text;

namespace EncodingPerfTests.UTF8.GetBytes
{
    class With500KChar : BaseTest
    {
        private readonly string _text;

        public With500KChar()
        {
            _text = UglyThings.GenerateText(500000);
        }

        protected override void OnRun()
        {
            Encoding.UTF8.GetBytes(_text);
        }

        protected override string Name => "GetBytes with 500K character values";
        protected override int Iterations => 100000; //100K
    }
}