using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace Egg_printer_pc
{
    class Command_to_RX62T
    {

        private UART uart = new UART();
        private byte[] command_buffer = new byte[8];

        public void Send_Command_step_angle(Selection selection, double angle, string com)
        {
            command_buffer[0] = (byte)((int)selection << (int)Command_Mask.Selection);
            command_buffer[0] = (byte)(command_buffer[0] | ((int)StepEnable.step_motor_enable << (int)Command_Mask.StepEnable));

            int cmd_5160 = (int)(angle / 360 * 51200);
            command_buffer[3] = 0xAD;
            command_buffer[4] = (byte)((cmd_5160 >> 24) & 0xff);
            command_buffer[5] = (byte)((cmd_5160 >> 16) & 0xff);
            command_buffer[6] = (byte)((cmd_5160 >> 8) & 0xff);
            command_buffer[7] = (byte)(cmd_5160 & 0xff);

            uart.Send_Command(command_buffer, com);
        }

        public void Send_Command_step_enable(Selection selection, StepEnable stepEnable, string com)
        {
            command_buffer[0] = (byte)((int)selection << (int)Command_Mask.Selection);
            command_buffer[0] = (byte)(command_buffer[0] | ((int)stepEnable << (int)Command_Mask.StepEnable));

            uart.Send_Command(command_buffer, com);
        }

        public void Send_Command_servo_value(UInt16 value, string com)
        {
            command_buffer[0] = (byte)((int)Selection.pen_servo << (int)Command_Mask.Selection);

            command_buffer[1] = (byte)(value & 0xff);
            command_buffer[2] = (byte)((value >> 8) & 0xff);

            uart.Send_Command(command_buffer, com);
        }

        public void Send_Command_initial(string com)
        {
            command_buffer[0] = 0xff;
            command_buffer[1] = 0xff;
            command_buffer[2] = 0xff;
            command_buffer[3] = 0xff;
            command_buffer[4] = 0xff;
            command_buffer[5] = 0xff;
            command_buffer[6] = 0xff;
            command_buffer[7] = 0xff;

            uart.Send_Command(command_buffer, com);
        }

        public int Read_Feedback(string com)
        {
            int buffer;
            command_buffer[0] = (byte)((int)Selection.read << (int)Command_Mask.Selection);
            uart.Send_Command(command_buffer, com);
            Thread.Sleep(UART.delayTime);
            buffer = uart.Read_Feedback(com);
            return buffer;
        }
    }
}
