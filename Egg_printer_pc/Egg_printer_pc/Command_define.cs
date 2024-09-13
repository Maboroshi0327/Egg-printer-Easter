using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egg_printer_pc
{
    public enum Selection
    {
        pen_step = 0x0,
        egg_step = 0x1,
        pen_servo = 0x2,
        read = 0x3
    }

    public enum StepEnable
    {
        step_motor_enable = 0x0,
        step_motor_disable = 0x1
    }
    
    public enum Command_Mask
    {
        Selection = 0,
        StepEnable = 2,
        Servo_Value = 8,
        Step_Motor_5160_Cmd = 24
    }

    static class Pen_Servo_State
    {
        public const UInt16 up = 2200;
        public const UInt16 down = 3000;
    }
}
