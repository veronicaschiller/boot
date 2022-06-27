using systemy;
using windowsInput;

namespace EnviarMenssagenWhatssap
{
    internal class program
    {
        static void Main(string[]   args)
        {
            string mensagem = "";
            int QuantDeMensagem = 0;
            int contador = 0;

            int inputsimulator = new inputsimulator();

            console.WriteLine('qual e a sua menssagem?');
            mensagem = console.Readline();
            console.WriteLine('quantas menssages vc quer enviar?');
            QuantDeMensagem = convert.ToInt32(console.Readline());

            for (int i = 0; i < contador; i++)
            {
                console.WriteLine('----------------->' + (contador - i));
                Thread.sleep(1000);
            }

            console.WriteLine("já --------------------");

            for (int i = 0; i < QuantDeMensagem; i++)
            {
                inputsimulator.Keyboard.textEntry(mensagem);
                inputsimulator.Keyboard.keyPress(windowsInput.Native.VirtualKeyCode.RETURN);
                Thread.sleep(250);

                console.WriteLine("mensagens enviadas");
            }


        }
    }
}
