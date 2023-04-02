namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /* DateTime() é um tipo do C# que manipula datas.
             * Se somente instanciarmos o DateTime() em uma variável, ele vai armazenar a data 01/01/0001 */
            var dataDefault = new DateTime();
            Console.WriteLine("DateTime() default: " + dataDefault);

            /* Para retornar a data atual use DateTime.Now; */
            var hoje = DateTime.Now;
            Console.WriteLine("DateTime.Now: " + hoje);

            /* Para settar uma data manualmente passe como parametro na instanciação da classe DateTime() */
            /* Ano, Mês, Dia, Hora, Minuto, Segundo */
            var manualmente = new DateTime(2020, 10, 12, 13, 23, 14);

            /* Aqui estão listadas algumas propriedades do DateTime com valores que podem ser extraídos */
            Console.WriteLine("Manualmente: " + manualmente);
            Console.WriteLine("Ano: " + manualmente.Year);
            Console.WriteLine("Mês: " + manualmente.Month);
            Console.WriteLine("Dia: " + manualmente.Day);
            Console.WriteLine("Hora: " + manualmente.Hour);
            Console.WriteLine("Minuto: " + manualmente.Minute);
            Console.WriteLine("Segundo:" + manualmente.Second);
            Console.WriteLine("Dia da Semana: " + manualmente.DayOfWeek);
            Console.WriteLine("Dia do ano: " + manualmente.DayOfYear);

            /* Para formatar a data manualmente use o String.Format("{índice:formatação}", variavel) 
             * No caso como só tem uma variável o índice é 0, e como separador pode colocar o que quiser
             * A quantidade de letras expecifica a forma como a formatação vai ser feita, podendo variar de 1 a até 4
             * no ano por exemplo: y~~yy = 23 / yyy~~yyyy = 2023
             * dd: Dia
             * MM: Mês
             * yyyy: Ano
             * hh: Hora
             * mm: Minuto
             * ss: Segundo
             * ff: Milissegundos
             * z: TimeZone
             * t: Short Pattern pra Hora
             * d: Short Pattern pra Data
             * g: Short Pattern pra Data e Hora
             * T: Long Pattern pra Hora
             * D: Long Pattern pra Data
             * f: Long Pattern pra Data e Hora
             * r: 
             */
            var formatada = String.Format("{0:dd-MM-yyy hh-mm-ss}", hoje);
            Console.WriteLine("Hora Formatada Manualmente: " + formatada);
            formatada = String.Format("Short Pattern: {0:d}\nLong Pattern: {0:D}", hoje);
            Console.WriteLine(formatada);
        }
    }
}