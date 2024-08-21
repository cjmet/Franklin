
namespace Franklin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            While helping you with your Essay on Benjamin Franklin, it appears 
            Kitty Tiger decided transcribe it in a strange Franklin like cipher.
            
            Can you help Kitty Tiger translate it back to English before it's 
            too Late?  
            
            Use a string extension method to translate the cipher back to English.

            */

            String cipherString = "nimajneB nilknarF SRF ASRF ESRF yraunaJ( ,71 6071 .S.O[ yraunaJ ,6 etoN[]5071 ]1 - lirpA ,71 )0971 saw na naciremA :htamylop a gnidael ,retirw ,tsitneics ,rotnevni ,namsetats ,tamolpid ,retnirp rehsilbup dna lacitilop ]1[.rehposolihp gnomA eht tsom laitneulfni slautcelletni fo sih ,emit nilknarF saw eno fo eht gnidnuoF srehtaF fo eht detinU ;setatS a retfard dna rengis fo eht noitaralceD fo ;ecnednepednI dna eht tsrif retsamtsop ]2[.lareneg";

            Console.WriteLine($"Translating Kitten:");
            Console.WriteLine($"----------------------------\n");
            Console.WriteLine($"Original:\n{cipherString}\n");
            Console.WriteLine($"Translation:");

            Console.WriteLine(cipherString.Franklin());

            Console.WriteLine($"\n");
        }
    }
}