using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Copier : BaseDevice, IPrinter, IScanner
    {
        public int PrintCounter { get; private set; } = 0;
        public int ScanCounter { get; private set; } = 0;
        
        public void Print(in IDocument document)
        {
            if (state == IDevice.State.on)
            {
                PrintCounter++;
                Console.WriteLine($"{DateTime.Now} Print: {document.GetFileName}");
                return;
            }
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            if (state == IDevice.State.on)
            {
                ScanCounter++;
                switch (formatType)
                {
                    case IDocument.FormatType.TXT:
                        {
                            break;
                        }
                    case IDocument.FormatType.PDF:
                        {
                            break;
                        }
                    case IDocument.FormatType.JPG:
                        {
                            break;
                        }
                    default:
                        break;
                }
                Console.WriteLine($"{DateTime.Now} Scan: {}");
            }
        }
    }
}
