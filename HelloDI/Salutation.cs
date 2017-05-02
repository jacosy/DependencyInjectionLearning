using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDI
{
    public interface ISalutaion
    {
        void Exclaim();
    }

    public class Salutation : ISalutaion
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            this.writer = writer;
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI!");
        }
    }
}
