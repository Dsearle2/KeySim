using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace KeySim
{
    public class KeySim
    {
        public class KeyDown
        {
            public static void LBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LBUTTON;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RBUTTON;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CANCEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CANCEL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MBUTTON;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void XBUTTON1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.XBUTTON1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void XBUTTON2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.XBUTTON2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BACK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void TAB()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.TAB;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CLEAR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CLEAR;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RETURN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RETURN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SHIFT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CONTROL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MENU;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PAUSE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PAUSE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CAPITAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CAPITAL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KANA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KANA;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HANGUL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HANGUL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void JUNJA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.JUNJA;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void FINAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.FINAL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HANJA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HANJA;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KANJI()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KANJI;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ESCAPE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ESCAPE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CONVERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CONVERT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NONCONVERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NONCONVERT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ACCEPT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ACCEPT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MODECHANGE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MODECHANGE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SPACE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SPACE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PRIOR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PRIOR;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NEXT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NEXT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void END()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.END;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HOME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HOME;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LEFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LEFT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void UP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.UP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RIGHT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RIGHT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DOWN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DOWN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SELECT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SELECT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PRINT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PRINT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EXECUTE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EXECUTE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SNAPSHOT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SNAPSHOT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void INSERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.INSERT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DELETE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DELETE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HELP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HELP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_0()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_0;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_3;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_4;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_5;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_6;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_7;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_8;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_9;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_A()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_A;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_B()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_B;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_C()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_C;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_D()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_D;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_E()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_E;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_F()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_F;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_G()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_G;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_H()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_H;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_I()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_I;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_J()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_J;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_K()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_K;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_L()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_L;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_M()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_M;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_N()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_N;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_O()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_O;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_P()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_P;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Q()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Q;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_R()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_R;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_S()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_S;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_T()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_T;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_U()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_U;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_V()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_V;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_W()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_W;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_X()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_X;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Y()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Y;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Z()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Z;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LWIN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LWIN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RWIN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RWIN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void APPS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.APPS;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SLEEP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SLEEP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD0()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD0;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD3;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD4;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD5;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD6;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD7;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD8;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD9;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MULTIPLY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MULTIPLY;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ADD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ADD;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SEPARATOR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SEPARATOR;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SUBTRACT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SUBTRACT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DECIMAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DECIMAL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DIVIDE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DIVIDE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F3;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F4;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F5;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F6;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F7;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F8;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F9;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F10()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F10;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F11()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F11;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F12()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F12;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F13()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F13;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F14()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F14;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F15()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F15;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F16()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F16;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F17()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F17;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F18()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F18;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F19()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F19;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F20()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F20;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F21()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F21;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F22()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F22;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F23()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F23;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F24()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F24;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMLOCK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMLOCK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SCROLL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SCROLL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LSHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LSHIFT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RSHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RSHIFT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LCONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LCONTROL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RCONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RCONTROL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LMENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LMENU;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RMENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RMENU;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_BACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_BACK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_FORWARD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_FORWARD;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_REFRESH()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_REFRESH;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_STOP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_STOP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_SEARCH()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_SEARCH;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_FAVORITES()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_FAVORITES;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_HOME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_HOME;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_MUTE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_MUTE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_DOWN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_DOWN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_UP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_UP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_NEXT_TRACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_NEXT_TRACK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_PREV_TRACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_PREV_TRACK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_STOP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_STOP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_PLAY_PAUSE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_PLAY_PAUSE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_MAIL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_MAIL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_MEDIA_SELECT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_MEDIA_SELECT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_APP1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_APP1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_APP2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_APP2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_PLUS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_PLUS;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_COMMA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_COMMA;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_MINUS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_MINUS;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_PERIOD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_PERIOD;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_3;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_4;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_5;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_6;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_7;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_8;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_102()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_102;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PROCESSKEY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PROCESSKEY;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PACKET()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PACKET;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ATTN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ATTN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CRSEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CRSEL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EXSEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EXSEL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EREOF()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EREOF;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PLAY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PLAY;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ZOOM()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ZOOM;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NONAME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NONAME;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PA1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PA1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_CLEAR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_CLEAR;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }
        }

        public class KeyUp
        {
            public static void LBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LBUTTON;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RBUTTON;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CANCEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CANCEL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MBUTTON;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void XBUTTON1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.XBUTTON1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void XBUTTON2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.XBUTTON2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BACK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void TAB()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.TAB;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CLEAR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CLEAR;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RETURN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RETURN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SHIFT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CONTROL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MENU;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PAUSE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PAUSE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CAPITAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CAPITAL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KANA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KANA;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HANGUL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HANGUL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void JUNJA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.JUNJA;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void FINAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.FINAL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HANJA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HANJA;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KANJI()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KANJI;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ESCAPE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ESCAPE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CONVERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CONVERT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NONCONVERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NONCONVERT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ACCEPT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ACCEPT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MODECHANGE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MODECHANGE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SPACE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SPACE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PRIOR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PRIOR;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NEXT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NEXT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void END()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.END;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HOME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HOME;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LEFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LEFT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void UP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.UP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RIGHT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RIGHT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DOWN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DOWN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SELECT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SELECT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PRINT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PRINT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EXECUTE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EXECUTE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SNAPSHOT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SNAPSHOT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void INSERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.INSERT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DELETE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DELETE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HELP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HELP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_0()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_0;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_3;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_4;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_5;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_6;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_7;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_8;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_9;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_A()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_A;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_B()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_B;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_C()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_C;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_D()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_D;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_E()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_E;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_F()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_F;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_G()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_G;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_H()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_H;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_I()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_I;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_J()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_J;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_K()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_K;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_L()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_L;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_M()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_M;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_N()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_N;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_O()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_O;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_P()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_P;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Q()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Q;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_R()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_R;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_S()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_S;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_T()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_T;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_U()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_U;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_V()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_V;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_W()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_W;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_X()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_X;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Y()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Y;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Z()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Z;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LWIN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LWIN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RWIN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RWIN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void APPS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.APPS;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SLEEP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SLEEP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD0()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD0;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD3;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD4;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD5;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD6;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD7;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD8;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD9;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MULTIPLY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MULTIPLY;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ADD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ADD;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SEPARATOR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SEPARATOR;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SUBTRACT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SUBTRACT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DECIMAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DECIMAL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DIVIDE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DIVIDE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F3;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F4;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F5;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F6;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F7;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F8;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F9;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F10()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F10;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F11()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F11;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F12()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F12;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F13()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F13;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F14()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F14;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F15()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F15;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F16()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F16;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F17()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F17;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F18()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F18;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F19()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F19;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F20()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F20;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F21()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F21;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F22()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F22;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F23()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F23;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F24()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F24;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMLOCK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMLOCK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SCROLL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SCROLL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LSHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LSHIFT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RSHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RSHIFT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LCONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LCONTROL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RCONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RCONTROL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LMENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LMENU;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RMENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RMENU;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_BACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_BACK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_FORWARD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_FORWARD;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_REFRESH()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_REFRESH;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_STOP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_STOP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_SEARCH()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_SEARCH;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_FAVORITES()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_FAVORITES;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_HOME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_HOME;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_MUTE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_MUTE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_DOWN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_DOWN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_UP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_UP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_NEXT_TRACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_NEXT_TRACK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_PREV_TRACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_PREV_TRACK;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_STOP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_STOP;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_PLAY_PAUSE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_PLAY_PAUSE;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_MAIL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_MAIL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_MEDIA_SELECT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_MEDIA_SELECT;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_APP1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_APP1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_APP2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_APP2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_PLUS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_PLUS;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_COMMA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_COMMA;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_MINUS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_MINUS;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_PERIOD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_PERIOD;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_2;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_3;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_4;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_5;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_6;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_7;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_8;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_102()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_102;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PROCESSKEY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PROCESSKEY;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PACKET()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PACKET;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ATTN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ATTN;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CRSEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CRSEL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EXSEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EXSEL;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EREOF()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EREOF;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PLAY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PLAY;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ZOOM()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ZOOM;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NONAME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NONAME;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PA1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PA1;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_CLEAR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_CLEAR;
                Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
                Input.U.ki.dwFlags |= KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }
        }

        public class SendKey
        {
            public static void LBUTTON()
            {
                KeyDown.LBUTTON();
                Thread.Sleep(10);
                KeyUp.LBUTTON();
            }

            public static void RBUTTON()
            {
                KeyDown.RBUTTON();
                Thread.Sleep(10);
                KeyUp.RBUTTON();
            }

            public static void CANCEL()
            {
                KeyDown.CANCEL();
                Thread.Sleep(10);
                KeyUp.CANCEL();
            }

            public static void MBUTTON()
            {
                KeyDown.MBUTTON();
                Thread.Sleep(10);
                KeyUp.MBUTTON();
            }

            public static void XBUTTON1()
            {
                KeyDown.XBUTTON1();
                Thread.Sleep(10);
                KeyUp.XBUTTON1();
            }

            public static void XBUTTON2()
            {
                KeyDown.XBUTTON2();
                Thread.Sleep(10);
                KeyUp.XBUTTON2();
            }

            public static void BACK()
            {
                KeyDown.BACK();
                Thread.Sleep(10);
                KeyUp.BACK();
            }

            public static void TAB()
            {
                KeyDown.TAB();
                Thread.Sleep(10);
                KeyUp.TAB();
            }

            public static void CLEAR()
            {
                KeyDown.CLEAR();
                Thread.Sleep(10);
                KeyUp.CLEAR();
            }

            public static void RETURN()
            {
                KeyDown.RETURN();
                Thread.Sleep(10);
                KeyUp.RETURN();
            }

            public static void SHIFT()
            {
                KeyDown.SHIFT();
                Thread.Sleep(10);
                KeyUp.SHIFT();
            }

            public static void CONTROL()
            {
                KeyDown.CONTROL();
                Thread.Sleep(10);
                KeyUp.CONTROL();
            }

            public static void MENU()
            {
                KeyDown.MENU();
                Thread.Sleep(10);
                KeyUp.MENU();
            }

            public static void PAUSE()
            {
                KeyDown.PAUSE();
                Thread.Sleep(10);
                KeyUp.PAUSE();
            }

            public static void CAPITAL()
            {
                KeyDown.CAPITAL();
                Thread.Sleep(10);
                KeyUp.CAPITAL();
            }

            public static void KANA()
            {
                KeyDown.KANA();
                Thread.Sleep(10);
                KeyUp.KANA();
            }

            public static void HANGUL()
            {
                KeyDown.HANGUL();
                Thread.Sleep(10);
                KeyUp.HANGUL();
            }

            public static void JUNJA()
            {
                KeyDown.JUNJA();
                Thread.Sleep(10);
                KeyUp.JUNJA();
            }

            public static void FINAL()
            {
                KeyDown.FINAL();
                Thread.Sleep(10);
                KeyUp.FINAL();
            }

            public static void HANJA()
            {
                KeyDown.HANJA();
                Thread.Sleep(10);
                KeyUp.HANJA();
            }

            public static void KANJI()
            {
                KeyDown.KANJI();
                Thread.Sleep(10);
                KeyUp.KANJI();
            }

            public static void ESCAPE()
            {
                KeyDown.ESCAPE();
                Thread.Sleep(10);
                KeyUp.ESCAPE();
            }

            public static void CONVERT()
            {
                KeyDown.CONVERT();
                Thread.Sleep(10);
                KeyUp.CONVERT();
            }

            public static void NONCONVERT()
            {
                KeyDown.NONCONVERT();
                Thread.Sleep(10);
                KeyUp.NONCONVERT();
            }

            public static void ACCEPT()
            {
                KeyDown.ACCEPT();
                Thread.Sleep(10);
                KeyUp.ACCEPT();
            }

            public static void MODECHANGE()
            {
                KeyDown.MODECHANGE();
                Thread.Sleep(10);
                KeyUp.MODECHANGE();
            }

            public static void SPACE()
            {
                KeyDown.SPACE();
                Thread.Sleep(10);
                KeyUp.SPACE();
            }

            public static void PRIOR()
            {
                KeyDown.PRIOR();
                Thread.Sleep(10);
                KeyUp.PRIOR();
            }

            public static void NEXT()
            {
                KeyDown.NEXT();
                Thread.Sleep(10);
                KeyUp.NEXT();
            }

            public static void END()
            {
                KeyDown.END();
                Thread.Sleep(10);
                KeyUp.END();
            }

            public static void HOME()
            {
                KeyDown.HOME();
                Thread.Sleep(10);
                KeyUp.HOME();
            }

            public static void LEFT()
            {
                KeyDown.LEFT();
                Thread.Sleep(10);
                KeyUp.LEFT();
            }

            public static void UP()
            {
                KeyDown.UP();
                Thread.Sleep(10);
                KeyUp.UP();
            }

            public static void RIGHT()
            {
                KeyDown.RIGHT();
                Thread.Sleep(10);
                KeyUp.RIGHT();
            }

            public static void DOWN()
            {
                KeyDown.DOWN();
                Thread.Sleep(10);
                KeyUp.DOWN();
            }

            public static void SELECT()
            {
                KeyDown.SELECT();
                Thread.Sleep(10);
                KeyUp.SELECT();
            }

            public static void PRINT()
            {
                KeyDown.PRINT();
                Thread.Sleep(10);
                KeyUp.PRINT();
            }

            public static void EXECUTE()
            {
                KeyDown.EXECUTE();
                Thread.Sleep(10);
                KeyUp.EXECUTE();
            }

            public static void SNAPSHOT()
            {
                KeyDown.SNAPSHOT();
                Thread.Sleep(10);
                KeyUp.SNAPSHOT();
            }

            public static void INSERT()
            {
                KeyDown.INSERT();
                Thread.Sleep(10);
                KeyUp.INSERT();
            }

            public static void DELETE()
            {
                KeyDown.DELETE();
                Thread.Sleep(10);
                KeyUp.DELETE();
            }

            public static void HELP()
            {
                KeyDown.HELP();
                Thread.Sleep(10);
                KeyUp.HELP();
            }

            public static void KEY_0()
            {
                KeyDown.KEY_0();
                Thread.Sleep(10);
                KeyUp.KEY_0();
            }

            public static void KEY_1()
            {
                KeyDown.KEY_1();
                Thread.Sleep(10);
                KeyUp.KEY_1();
            }

            public static void KEY_2()
            {
                KeyDown.KEY_2();
                Thread.Sleep(10);
                KeyUp.KEY_2();
            }

            public static void KEY_3()
            {
                KeyDown.KEY_3();
                Thread.Sleep(10);
                KeyUp.KEY_3();
            }

            public static void KEY_4()
            {
                KeyDown.KEY_4();
                Thread.Sleep(10);
                KeyUp.KEY_4();
            }

            public static void KEY_5()
            {
                KeyDown.KEY_5();
                Thread.Sleep(10);
                KeyUp.KEY_5();
            }

            public static void KEY_6()
            {
                KeyDown.KEY_6();
                Thread.Sleep(10);
                KeyUp.KEY_6();
            }

            public static void KEY_7()
            {
                KeyDown.KEY_7();
                Thread.Sleep(10);
                KeyUp.KEY_7();
            }

            public static void KEY_8()
            {
                KeyDown.KEY_8();
                Thread.Sleep(10);
                KeyUp.KEY_8();
            }

            public static void KEY_9()
            {
                KeyDown.KEY_9();
                Thread.Sleep(10);
                KeyUp.KEY_9();
            }

            public static void KEY_A()
            {
                KeyDown.KEY_A();
                Thread.Sleep(10);
                KeyUp.KEY_A();
            }

            public static void KEY_B()
            {
                KeyDown.KEY_B();
                Thread.Sleep(10);
                KeyUp.KEY_B();
            }

            public static void KEY_C()
            {
                KeyDown.KEY_C();
                Thread.Sleep(10);
                KeyUp.KEY_C();
            }

            public static void KEY_D()
            {
                KeyDown.KEY_D();
                Thread.Sleep(10);
                KeyUp.KEY_D();
            }

            public static void KEY_E()
            {
                KeyDown.KEY_E();
                Thread.Sleep(10);
                KeyUp.KEY_E();
            }

            public static void KEY_F()
            {
                KeyDown.KEY_F();
                Thread.Sleep(10);
                KeyUp.KEY_F();
            }

            public static void KEY_G()
            {
                KeyDown.KEY_G();
                Thread.Sleep(10);
                KeyUp.KEY_G();
            }

            public static void KEY_H()
            {
                KeyDown.KEY_H();
                Thread.Sleep(10);
                KeyUp.KEY_H();
            }

            public static void KEY_I()
            {
                KeyDown.KEY_I();
                Thread.Sleep(10);
                KeyUp.KEY_I();
            }

            public static void KEY_J()
            {
                KeyDown.KEY_J();
                Thread.Sleep(10);
                KeyUp.KEY_J();
            }

            public static void KEY_K()
            {
                KeyDown.KEY_K();
                Thread.Sleep(10);
                KeyUp.KEY_K();
            }

            public static void KEY_L()
            {
                KeyDown.KEY_L();
                Thread.Sleep(10);
                KeyUp.KEY_L();
            }

            public static void KEY_M()
            {
                KeyDown.KEY_M();
                Thread.Sleep(10);
                KeyUp.KEY_M();
            }

            public static void KEY_N()
            {
                KeyDown.KEY_N();
                Thread.Sleep(10);
                KeyUp.KEY_N();
            }

            public static void KEY_O()
            {
                KeyDown.KEY_O();
                Thread.Sleep(10);
                KeyUp.KEY_O();
            }

            public static void KEY_P()
            {
                KeyDown.KEY_P();
                Thread.Sleep(10);
                KeyUp.KEY_P();
            }

            public static void KEY_Q()
            {
                KeyDown.KEY_Q();
                Thread.Sleep(10);
                KeyUp.KEY_Q();
            }

            public static void KEY_R()
            {
                KeyDown.KEY_R();
                Thread.Sleep(10);
                KeyUp.KEY_R();
            }

            public static void KEY_S()
            {
                KeyDown.KEY_S();
                Thread.Sleep(10);
                KeyUp.KEY_S();
            }

            public static void KEY_T()
            {
                KeyDown.KEY_T();
                Thread.Sleep(10);
                KeyUp.KEY_T();
            }

            public static void KEY_U()
            {
                KeyDown.KEY_U();
                Thread.Sleep(10);
                KeyUp.KEY_U();
            }

            public static void KEY_V()
            {
                KeyDown.KEY_V();
                Thread.Sleep(10);
                KeyUp.KEY_V();
            }

            public static void KEY_W()
            {
                KeyDown.KEY_W();
                Thread.Sleep(10);
                KeyUp.KEY_W();
            }

            public static void KEY_X()
            {
                KeyDown.KEY_X();
                Thread.Sleep(10);
                KeyUp.KEY_X();
            }

            public static void KEY_Y()
            {
                KeyDown.KEY_Y();
                Thread.Sleep(10);
                KeyUp.KEY_Y();
            }

            public static void KEY_Z()
            {
                KeyDown.KEY_Z();
                Thread.Sleep(10);
                KeyUp.KEY_Z();
            }

            public static void LWIN()
            {
                KeyDown.LWIN();
                Thread.Sleep(10);
                KeyUp.LWIN();
            }

            public static void RWIN()
            {
                KeyDown.RWIN();
                Thread.Sleep(10);
                KeyUp.RWIN();
            }

            public static void APPS()
            {
                KeyDown.APPS();
                Thread.Sleep(10);
                KeyUp.APPS();
            }

            public static void SLEEP()
            {
                KeyDown.SLEEP();
                Thread.Sleep(10);
                KeyUp.SLEEP();
            }

            public static void NUMPAD0()
            {
                KeyDown.NUMPAD0();
                Thread.Sleep(10);
                KeyUp.NUMPAD0();
            }

            public static void NUMPAD1()
            {
                KeyDown.NUMPAD1();
                Thread.Sleep(10);
                KeyUp.NUMPAD1();
            }

            public static void NUMPAD2()
            {
                KeyDown.NUMPAD2();
                Thread.Sleep(10);
                KeyUp.NUMPAD2();
            }

            public static void NUMPAD3()
            {
                KeyDown.NUMPAD3();
                Thread.Sleep(10);
                KeyUp.NUMPAD3();
            }

            public static void NUMPAD4()
            {
                KeyDown.NUMPAD4();
                Thread.Sleep(10);
                KeyUp.NUMPAD4();
            }

            public static void NUMPAD5()
            {
                KeyDown.NUMPAD5();
                Thread.Sleep(10);
                KeyUp.NUMPAD5();
            }

            public static void NUMPAD6()
            {
                KeyDown.NUMPAD6();
                Thread.Sleep(10);
                KeyUp.NUMPAD6();
            }

            public static void NUMPAD7()
            {
                KeyDown.NUMPAD7();
                Thread.Sleep(10);
                KeyUp.NUMPAD7();
            }

            public static void NUMPAD8()
            {
                KeyDown.NUMPAD8();
                Thread.Sleep(10);
                KeyUp.NUMPAD8();
            }

            public static void NUMPAD9()
            {
                KeyDown.NUMPAD9();
                Thread.Sleep(10);
                KeyUp.NUMPAD9();
            }

            public static void MULTIPLY()
            {
                KeyDown.MULTIPLY();
                Thread.Sleep(10);
                KeyUp.MULTIPLY();
            }

            public static void ADD()
            {
                KeyDown.ADD();
                Thread.Sleep(10);
                KeyUp.ADD();
            }

            public static void SEPARATOR()
            {
                KeyDown.SEPARATOR();
                Thread.Sleep(10);
                KeyUp.SEPARATOR();
            }

            public static void SUBTRACT()
            {
                KeyDown.SUBTRACT();
                Thread.Sleep(10);
                KeyUp.SUBTRACT();
            }

            public static void DECIMAL()
            {
                KeyDown.DECIMAL();
                Thread.Sleep(10);
                KeyUp.DECIMAL();
            }

            public static void DIVIDE()
            {
                KeyDown.DIVIDE();
                Thread.Sleep(10);
                KeyUp.DIVIDE();
            }

            public static void F1()
            {
                KeyDown.F1();
                Thread.Sleep(10);
                KeyUp.F1();
            }

            public static void F2()
            {
                KeyDown.F2();
                Thread.Sleep(10);
                KeyUp.F2();
            }

            public static void F3()
            {
                KeyDown.F3();
                Thread.Sleep(10);
                KeyUp.F3();
            }

            public static void F4()
            {
                KeyDown.F4();
                Thread.Sleep(10);
                KeyUp.F4();
            }

            public static void F5()
            {
                KeyDown.F5();
                Thread.Sleep(10);
                KeyUp.F5();
            }

            public static void F6()
            {
                KeyDown.F6();
                Thread.Sleep(10);
                KeyUp.F6();
            }

            public static void F7()
            {
                KeyDown.F7();
                Thread.Sleep(10);
                KeyUp.F7();
            }

            public static void F8()
            {
                KeyDown.F8();
                Thread.Sleep(10);
                KeyUp.F8();
            }

            public static void F9()
            {
                KeyDown.F9();
                Thread.Sleep(10);
                KeyUp.F9();
            }

            public static void F10()
            {
                KeyDown.F10();
                Thread.Sleep(10);
                KeyUp.F10();
            }

            public static void F11()
            {
                KeyDown.F11();
                Thread.Sleep(10);
                KeyUp.F11();
            }

            public static void F12()
            {
                KeyDown.F12();
                Thread.Sleep(10);
                KeyUp.F12();
            }

            public static void F13()
            {
                KeyDown.F13();
                Thread.Sleep(10);
                KeyUp.F13();
            }

            public static void F14()
            {
                KeyDown.F14();
                Thread.Sleep(10);
                KeyUp.F14();
            }

            public static void F15()
            {
                KeyDown.F15();
                Thread.Sleep(10);
                KeyUp.F15();
            }

            public static void F16()
            {
                KeyDown.F16();
                Thread.Sleep(10);
                KeyUp.F16();
            }

            public static void F17()
            {
                KeyDown.F17();
                Thread.Sleep(10);
                KeyUp.F17();
            }

            public static void F18()
            {
                KeyDown.F18();
                Thread.Sleep(10);
                KeyUp.F18();
            }

            public static void F19()
            {
                KeyDown.F19();
                Thread.Sleep(10);
                KeyUp.F19();
            }

            public static void F20()
            {
                KeyDown.F20();
                Thread.Sleep(10);
                KeyUp.F20();
            }

            public static void F21()
            {
                KeyDown.F21();
                Thread.Sleep(10);
                KeyUp.F21();
            }

            public static void F22()
            {
                KeyDown.F22();
                Thread.Sleep(10);
                KeyUp.F22();
            }

            public static void F23()
            {
                KeyDown.F23();
                Thread.Sleep(10);
                KeyUp.F23();
            }

            public static void F24()
            {
                KeyDown.F24();
                Thread.Sleep(10);
                KeyUp.F24();
            }

            public static void NUMLOCK()
            {
                KeyDown.NUMLOCK();
                Thread.Sleep(10);
                KeyUp.NUMLOCK();
            }

            public static void SCROLL()
            {
                KeyDown.SCROLL();
                Thread.Sleep(10);
                KeyUp.SCROLL();
            }

            public static void LSHIFT()
            {
                KeyDown.LSHIFT();
                Thread.Sleep(10);
                KeyUp.LSHIFT();
            }

            public static void RSHIFT()
            {
                KeyDown.RSHIFT();
                Thread.Sleep(10);
                KeyUp.RSHIFT();
            }

            public static void LCONTROL()
            {
                KeyDown.LCONTROL();
                Thread.Sleep(10);
                KeyUp.LCONTROL();
            }

            public static void RCONTROL()
            {
                KeyDown.RCONTROL();
                Thread.Sleep(10);
                KeyUp.RCONTROL();
            }

            public static void LMENU()
            {
                KeyDown.LMENU();
                Thread.Sleep(10);
                KeyUp.LMENU();
            }

            public static void RMENU()
            {
                KeyDown.RMENU();
                Thread.Sleep(10);
                KeyUp.RMENU();
            }

            public static void BROWSER_BACK()
            {
                KeyDown.BROWSER_BACK();
                Thread.Sleep(10);
                KeyUp.BROWSER_BACK();
            }

            public static void BROWSER_FORWARD()
            {
                KeyDown.BROWSER_FORWARD();
                Thread.Sleep(10);
                KeyUp.BROWSER_FORWARD();
            }

            public static void BROWSER_REFRESH()
            {
                KeyDown.BROWSER_REFRESH();
                Thread.Sleep(10);
                KeyUp.BROWSER_REFRESH();
            }

            public static void BROWSER_STOP()
            {
                KeyDown.BROWSER_STOP();
                Thread.Sleep(10);
                KeyUp.BROWSER_STOP();
            }

            public static void BROWSER_SEARCH()
            {
                KeyDown.BROWSER_SEARCH();
                Thread.Sleep(10);
                KeyUp.BROWSER_SEARCH();
            }

            public static void BROWSER_FAVORITES()
            {
                KeyDown.BROWSER_FAVORITES();
                Thread.Sleep(10);
                KeyUp.BROWSER_FAVORITES();
            }

            public static void BROWSER_HOME()
            {
                KeyDown.BROWSER_HOME();
                Thread.Sleep(10);
                KeyUp.BROWSER_HOME();
            }

            public static void VOLUME_MUTE()
            {
                KeyDown.VOLUME_MUTE();
                Thread.Sleep(10);
                KeyUp.VOLUME_MUTE();
            }

            public static void VOLUME_DOWN()
            {
                KeyDown.VOLUME_DOWN();
                Thread.Sleep(10);
                KeyUp.VOLUME_DOWN();
            }

            public static void VOLUME_UP()
            {
                KeyDown.VOLUME_UP();
                Thread.Sleep(10);
                KeyUp.VOLUME_UP();
            }

            public static void MEDIA_NEXT_TRACK()
            {
                KeyDown.MEDIA_NEXT_TRACK();
                Thread.Sleep(10);
                KeyUp.MEDIA_NEXT_TRACK();
            }

            public static void MEDIA_PREV_TRACK()
            {
                KeyDown.MEDIA_PREV_TRACK();
                Thread.Sleep(10);
                KeyUp.MEDIA_PREV_TRACK();
            }

            public static void MEDIA_STOP()
            {
                KeyDown.MEDIA_STOP();
                Thread.Sleep(10);
                KeyUp.MEDIA_STOP();
            }

            public static void MEDIA_PLAY_PAUSE()
            {
                KeyDown.MEDIA_PLAY_PAUSE();
                Thread.Sleep(10);
                KeyUp.MEDIA_PLAY_PAUSE();
            }

            public static void LAUNCH_MAIL()
            {
                KeyDown.LAUNCH_MAIL();
                Thread.Sleep(10);
                KeyUp.LAUNCH_MAIL();
            }

            public static void LAUNCH_MEDIA_SELECT()
            {
                KeyDown.LAUNCH_MEDIA_SELECT();
                Thread.Sleep(10);
                KeyUp.LAUNCH_MEDIA_SELECT();
            }

            public static void LAUNCH_APP1()
            {
                KeyDown.LAUNCH_APP1();
                Thread.Sleep(10);
                KeyUp.LAUNCH_APP1();
            }

            public static void LAUNCH_APP2()
            {
                KeyDown.LAUNCH_APP2();
                Thread.Sleep(10);
                KeyUp.LAUNCH_APP2();
            }

            public static void OEM_PLUS()
            {
                KeyDown.OEM_PLUS();
                Thread.Sleep(10);
                KeyUp.OEM_PLUS();
            }

            public static void OEM_COMMA()
            {
                KeyDown.OEM_COMMA();
                Thread.Sleep(10);
                KeyUp.OEM_COMMA();
            }

            public static void OEM_MINUS()
            {
                KeyDown.OEM_MINUS();
                Thread.Sleep(10);
                KeyUp.OEM_MINUS();
            }

            public static void OEM_PERIOD()
            {
                KeyDown.OEM_PERIOD();
                Thread.Sleep(10);
                KeyUp.OEM_PERIOD();
            }

            public static void OEM_1()
            {
                KeyDown.OEM_1();
                Thread.Sleep(10);
                KeyUp.OEM_1();
            }

            public static void OEM_2()
            {
                KeyDown.OEM_2();
                Thread.Sleep(10);
                KeyUp.OEM_2();
            }

            public static void OEM_3()
            {
                KeyDown.OEM_3();
                Thread.Sleep(10);
                KeyUp.OEM_3();
            }

            public static void OEM_4()
            {
                KeyDown.OEM_4();
                Thread.Sleep(10);
                KeyUp.OEM_4();
            }

            public static void OEM_5()
            {
                KeyDown.OEM_5();
                Thread.Sleep(10);
                KeyUp.OEM_5();
            }

            public static void OEM_6()
            {
                KeyDown.OEM_6();
                Thread.Sleep(10);
                KeyUp.OEM_6();
            }

            public static void OEM_7()
            {
                KeyDown.OEM_7();
                Thread.Sleep(10);
                KeyUp.OEM_7();
            }

            public static void OEM_8()
            {
                KeyDown.OEM_8();
                Thread.Sleep(10);
                KeyUp.OEM_8();
            }

            public static void OEM_102()
            {
                KeyDown.OEM_102();
                Thread.Sleep(10);
                KeyUp.OEM_102();
            }

            public static void PROCESSKEY()
            {
                KeyDown.PROCESSKEY();
                Thread.Sleep(10);
                KeyUp.PROCESSKEY();
            }

            public static void PACKET()
            {
                KeyDown.PACKET();
                Thread.Sleep(10);
                KeyUp.PACKET();
            }

            public static void ATTN()
            {
                KeyDown.ATTN();
                Thread.Sleep(10);
                KeyUp.ATTN();
            }

            public static void CRSEL()
            {
                KeyDown.CRSEL();
                Thread.Sleep(10);
                KeyUp.CRSEL();
            }

            public static void EXSEL()
            {
                KeyDown.EXSEL();
                Thread.Sleep(10);
                KeyUp.EXSEL();
            }

            public static void EREOF()
            {
                KeyDown.EREOF();
                Thread.Sleep(10);
                KeyUp.EREOF();
            }

            public static void PLAY()
            {
                KeyDown.PLAY();
                Thread.Sleep(10);
                KeyUp.PLAY();
            }

            public static void ZOOM()
            {
                KeyDown.ZOOM();
                Thread.Sleep(10);
                KeyUp.ZOOM();
            }

            public static void NONAME()
            {
                KeyDown.NONAME();
                Thread.Sleep(10);
                KeyUp.NONAME();
            }

            public static void PA1()
            {
                KeyDown.PA1();
                Thread.Sleep(10);
                KeyUp.PA1();
            }

            public static void OEM_CLEAR()
            {
                KeyDown.OEM_CLEAR();
                Thread.Sleep(10);
                KeyUp.OEM_CLEAR();
            }

            public static void KeycodeToKey(string keycode)
            {
                switch (keycode)
                {
                    case "LBUTTON":
                        LBUTTON();
                        break;
                    case "RBUTTON":
                        RBUTTON();
                        break;
                    case "CANCEL":
                        CANCEL();
                        break;
                    case "MBUTTON":
                        MBUTTON();
                        break;
                    case "XBUTTON1":
                        XBUTTON1();
                        break;
                    case "XBUTTON2":
                        XBUTTON2();
                        break;
                    case "BACK":
                        BACK();
                        break;
                    case "TAB":
                        TAB();
                        break;
                    case "CLEAR":
                        CLEAR();
                        break;
                    case "RETURN":
                        RETURN();
                        break;
                    case "SHIFT":
                        SHIFT();
                        break;
                    case "CONTROL":
                        CONTROL();
                        break;
                    case "MENU":
                        MENU();
                        break;
                    case "PAUSE":
                        PAUSE();
                        break;
                    case "CAPITAL":
                        CAPITAL();
                        break;
                    case "KANA":
                        KANA();
                        break;
                    case "HANGUL":
                        HANGUL();
                        break;
                    case "JUNJA":
                        JUNJA();
                        break;
                    case "FINAL":
                        FINAL();
                        break;
                    case "HANJA":
                        HANJA();
                        break;
                    case "KANJI":
                        KANJI();
                        break;
                    case "ESCAPE":
                        ESCAPE();
                        break;
                    case "CONVERT":
                        CONVERT();
                        break;
                    case "NONCONVERT":
                        NONCONVERT();
                        break;
                    case "ACCEPT":
                        ACCEPT();
                        break;
                    case "MODECHANGE":
                        MODECHANGE();
                        break;
                    case "SPACE":
                        SPACE();
                        break;
                    case "PRIOR":
                        PRIOR();
                        break;
                    case "NEXT":
                        NEXT();
                        break;
                    case "END":
                        END();
                        break;
                    case "HOME":
                        HOME();
                        break;
                    case "LEFT":
                        LEFT();
                        break;
                    case "UP":
                        UP();
                        break;
                    case "RIGHT":
                        RIGHT();
                        break;
                    case "DOWN":
                        DOWN();
                        break;
                    case "SELECT":
                        SELECT();
                        break;
                    case "PRINT":
                        PRINT();
                        break;
                    case "EXECUTE":
                        EXECUTE();
                        break;
                    case "SNAPSHOT":
                        SNAPSHOT();
                        break;
                    case "INSERT":
                        INSERT();
                        break;
                    case "DELETE":
                        DELETE();
                        break;
                    case "HELP":
                        HELP();
                        break;
                    case "KEY_0":
                        KEY_0();
                        break;
                    case "KEY_1":
                        KEY_1();
                        break;
                    case "KEY_2":
                        KEY_2();
                        break;
                    case "KEY_3":
                        KEY_3();
                        break;
                    case "KEY_4":
                        KEY_4();
                        break;
                    case "KEY_5":
                        KEY_5();
                        break;
                    case "KEY_6":
                        KEY_6();
                        break;
                    case "KEY_7":
                        KEY_7();
                        break;
                    case "KEY_8":
                        KEY_8();
                        break;
                    case "KEY_9":
                        KEY_9();
                        break;
                    case "KEY_A":
                        KEY_A();
                        break;
                    case "KEY_B":
                        KEY_B();
                        break;
                    case "KEY_C":
                        KEY_C();
                        break;
                    case "KEY_D":
                        KEY_D();
                        break;
                    case "KEY_E":
                        KEY_E();
                        break;
                    case "KEY_F":
                        KEY_F();
                        break;
                    case "KEY_G":
                        KEY_G();
                        break;
                    case "KEY_H":
                        KEY_H();
                        break;
                    case "KEY_I":
                        KEY_I();
                        break;
                    case "KEY_J":
                        KEY_J();
                        break;
                    case "KEY_K":
                        KEY_K();
                        break;
                    case "KEY_L":
                        KEY_L();
                        break;
                    case "KEY_M":
                        KEY_M();
                        break;
                    case "KEY_N":
                        KEY_N();
                        break;
                    case "KEY_O":
                        KEY_O();
                        break;
                    case "KEY_P":
                        KEY_P();
                        break;
                    case "KEY_Q":
                        KEY_Q();
                        break;
                    case "KEY_R":
                        KEY_R();
                        break;
                    case "KEY_S":
                        KEY_S();
                        break;
                    case "KEY_T":
                        KEY_T();
                        break;
                    case "KEY_U":
                        KEY_U();
                        break;
                    case "KEY_V":
                        KEY_V();
                        break;
                    case "KEY_W":
                        KEY_W();
                        break;
                    case "KEY_X":
                        KEY_X();
                        break;
                    case "KEY_Y":
                        KEY_Y();
                        break;
                    case "KEY_Z":
                        KEY_Z();
                        break;
                    case "LWIN":
                        LWIN();
                        break;
                    case "RWIN":
                        RWIN();
                        break;
                    case "APPS":
                        APPS();
                        break;
                    case "SLEEP":
                        SLEEP();
                        break;
                    case "NUMPAD0":
                        NUMPAD0();
                        break;
                    case "NUMPAD1":
                        NUMPAD1();
                        break;
                    case "NUMPAD2":
                        NUMPAD2();
                        break;
                    case "NUMPAD3":
                        NUMPAD3();
                        break;
                    case "NUMPAD4":
                        NUMPAD4();
                        break;
                    case "NUMPAD5":
                        NUMPAD5();
                        break;
                    case "NUMPAD6":
                        NUMPAD6();
                        break;
                    case "NUMPAD7":
                        NUMPAD7();
                        break;
                    case "NUMPAD8":
                        NUMPAD8();
                        break;
                    case "NUMPAD9":
                        NUMPAD9();
                        break;
                    case "MULTIPLY":
                        MULTIPLY();
                        break;
                    case "ADD":
                        ADD();
                        break;
                    case "SEPARATOR":
                        SEPARATOR();
                        break;
                    case "SUBTRACT":
                        SUBTRACT();
                        break;
                    case "DECIMAL":
                        DECIMAL();
                        break;
                    case "DIVIDE":
                        DIVIDE();
                        break;
                    case "F1":
                        F1();
                        break;
                    case "F2":
                        F2();
                        break;
                    case "F3":
                        F3();
                        break;
                    case "F4":
                        F4();
                        break;
                    case "F5":
                        F5();
                        break;
                    case "F6":
                        F6();
                        break;
                    case "F7":
                        F7();
                        break;
                    case "F8":
                        F8();
                        break;
                    case "F9":
                        F9();
                        break;
                    case "F10":
                        F10();
                        break;
                    case "F11":
                        F11();
                        break;
                    case "F12":
                        F12();
                        break;
                    case "F13":
                        F13();
                        break;
                    case "F14":
                        F14();
                        break;
                    case "F15":
                        F15();
                        break;
                    case "F16":
                        F16();
                        break;
                    case "F17":
                        F17();
                        break;
                    case "F18":
                        F18();
                        break;
                    case "F19":
                        F19();
                        break;
                    case "F20":
                        F20();
                        break;
                    case "F21":
                        F21();
                        break;
                    case "F22":
                        F22();
                        break;
                    case "F23":
                        F23();
                        break;
                    case "F24":
                        F24();
                        break;
                    case "NUMLOCK":
                        NUMLOCK();
                        break;
                    case "SCROLL":
                        SCROLL();
                        break;
                    case "LSHIFT":
                        LSHIFT();
                        break;
                    case "RSHIFT":
                        RSHIFT();
                        break;
                    case "LCONTROL":
                        LCONTROL();
                        break;
                    case "RCONTROL":
                        RCONTROL();
                        break;
                    case "LMENU":
                        LMENU();
                        break;
                    case "RMENU":
                        RMENU();
                        break;
                    case "BROWSER_BACK":
                        BROWSER_BACK();
                        break;
                    case "BROWSER_FORWARD":
                        BROWSER_FORWARD();
                        break;
                    case "BROWSER_REFRESH":
                        BROWSER_REFRESH();
                        break;
                    case "BROWSER_STOP":
                        BROWSER_STOP();
                        break;
                    case "BROWSER_SEARCH":
                        BROWSER_SEARCH();
                        break;
                    case "BROWSER_FAVORITES":
                        BROWSER_FAVORITES();
                        break;
                    case "BROWSER_HOME":
                        BROWSER_HOME();
                        break;
                    case "VOLUME_MUTE":
                        VOLUME_MUTE();
                        break;
                    case "VOLUME_DOWN":
                        VOLUME_DOWN();
                        break;
                    case "VOLUME_UP":
                        VOLUME_UP();
                        break;
                    case "MEDIA_NEXT_TRACK":
                        MEDIA_NEXT_TRACK();
                        break;
                    case "MEDIA_PREV_TRACK":
                        MEDIA_PREV_TRACK();
                        break;
                    case "MEDIA_STOP":
                        MEDIA_STOP();
                        break;
                    case "MEDIA_PLAY_PAUSE":
                        MEDIA_PLAY_PAUSE();
                        break;
                    case "LAUNCH_MAIL":
                        LAUNCH_MAIL();
                        break;
                    case "LAUNCH_MEDIA_SELECT":
                        LAUNCH_MEDIA_SELECT();
                        break;
                    case "LAUNCH_APP1":
                        LAUNCH_APP1();
                        break;
                    case "LAUNCH_APP2":
                        LAUNCH_APP2();
                        break;
                    case "OEM_1":
                        OEM_1();
                        break;
                    case "OEM_PLUS":
                        OEM_PLUS();
                        break;
                    case "OEM_COMMA":
                        OEM_COMMA();
                        break;
                    case "OEM_MINUS":
                        OEM_MINUS();
                        break;
                    case "OEM_PERIOD":
                        OEM_PERIOD();
                        break;
                    case "OEM_2":
                        OEM_2();
                        break;
                    case "OEM_3":
                        OEM_3();
                        break;
                    case "OEM_4":
                        OEM_4();
                        break;
                    case "OEM_5":
                        OEM_5();
                        break;
                    case "OEM_6":
                        OEM_6();
                        break;
                    case "OEM_7":
                        OEM_7();
                        break;
                    case "OEM_8":
                        OEM_8();
                        break;
                    case "OEM_102":
                        OEM_102();
                        break;
                    case "PROCESSKEY":
                        PROCESSKEY();
                        break;
                    case "PACKET":
                        PACKET();
                        break;
                    case "ATTN":
                        ATTN();
                        break;
                    case "CRSEL":
                        CRSEL();
                        break;
                    case "EXSEL":
                        EXSEL();
                        break;
                    case "EREOF":
                        EREOF();
                        break;
                    case "PLAY":
                        PLAY();
                        break;
                    case "ZOOM":
                        ZOOM();
                        break;
                    case "NONAME":
                        NONAME();
                        break;
                    case "PA1":
                        PA1();
                        break;
                    case "OEM_CLEAR":
                        OEM_CLEAR();
                        break;
                    default:
                        Console.WriteLine("Key Not Found!");
                        break;
                }
            }

            public static void RepeatKey(String keycode, int repeatcount, int pause)
            {
                for (int i = 0; i < repeatcount; i++)
                {
                    KeycodeToKey(keycode);
                    Thread.Sleep(pause);
                }
            }

            public static void StringToKeys(String keys, int pause)
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    String keycode = "";

                    if (keys[i].Equals('<'))
                    {
                        int j = i + 1;
                        Console.WriteLine("PointA");

                        do
                        {
                            keycode += Char.ToUpper(keys[j]).ToString();
                            Console.WriteLine(keycode);
                            j++;
                        } while (!keys[i].Equals('>') && j < keys.Length);
                        i = j;
                    }
                    else
                    {
                        if (Char.IsLetterOrDigit(keys[i]))
                        {
                            keycode = "KEY_" + Char.ToUpper(keys[i]).ToString();

                            if (Char.IsUpper(keys[i]))
                            {
                                KeyDown.SHIFT();
                            }
                        }
                        else if (Char.IsWhiteSpace(keys[i]))
                        {
                            keycode = "SPACE";
                        }
                    }
                    KeycodeToKey(keycode);
                    KeyUp.SHIFT();
                    Thread.Sleep(pause);
                }
            }
        }

        public class KeyThread
        {
            static Thread keyThread = null;
            static String key;
            static int wait;

            static void KeyRepeater()
            {
                do
                {
                    SendKey.KeycodeToKey(key);
                    Thread.Sleep(wait);
                } while (true);
            }

            public static void Start(String keycode, int pause)
            {
                key = keycode;
                wait = pause;

                ThreadStart checkerRef = new ThreadStart(KeyRepeater);
                keyThread = new Thread(checkerRef);
                keyThread.Start();
            }

            public static void Abort()
            {
                keyThread.Abort();
            }
            
        }

        [Obsolete]
        public class Obsolete
        {
            public static void LBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LBUTTON;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RBUTTON;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CANCEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CANCEL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MBUTTON()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MBUTTON;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void XBUTTON1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.XBUTTON1;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void XBUTTON2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.XBUTTON2;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BACK;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void TAB()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.TAB;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CLEAR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CLEAR;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RETURN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RETURN;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SHIFT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CONTROL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MENU;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PAUSE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PAUSE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CAPITAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CAPITAL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KANA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KANA;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HANGUL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HANGUL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void JUNJA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.JUNJA;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void FINAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.FINAL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HANJA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HANJA;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KANJI()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KANJI;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ESCAPE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ESCAPE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CONVERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CONVERT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NONCONVERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NONCONVERT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ACCEPT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ACCEPT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MODECHANGE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MODECHANGE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SPACE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SPACE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PRIOR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PRIOR;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NEXT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NEXT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void END()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.END;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HOME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HOME;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LEFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LEFT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void UP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.UP;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RIGHT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RIGHT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DOWN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DOWN;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SELECT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SELECT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PRINT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PRINT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EXECUTE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EXECUTE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SNAPSHOT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SNAPSHOT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void INSERT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.INSERT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DELETE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DELETE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void HELP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.HELP;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_0()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_0;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_1;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_2;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_3;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_4;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_5;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_6;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_7;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_8;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_9;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_A()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_A;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_B()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_B;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_C()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_C;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_D()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_D;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_E()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_E;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_F()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_F;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_G()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_G;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_H()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_H;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_I()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_I;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_J()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_J;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_K()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_K;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_L()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_L;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_M()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_M;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_N()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_N;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_O()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_O;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_P()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_P;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Q()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Q;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_R()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_R;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_S()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_S;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_T()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_T;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_U()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_U;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_V()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_V;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_W()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_W;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_X()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_X;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Y()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Y;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void KEY_Z()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.KEY_Z;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LWIN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LWIN;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RWIN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RWIN;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void APPS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.APPS;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SLEEP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SLEEP;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD0()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD0;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD1;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD2;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD3;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD4;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD5;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD6;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD7;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD8;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMPAD9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMPAD9;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MULTIPLY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MULTIPLY;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ADD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ADD;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SEPARATOR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SEPARATOR;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SUBTRACT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SUBTRACT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DECIMAL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DECIMAL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void DIVIDE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.DIVIDE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F1;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F2;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F3;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F4;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F5;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F6;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F7;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F8;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F9()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F9;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F10()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F10;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F11()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F11;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F12()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F12;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F13()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F13;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F14()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F14;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F15()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F15;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F16()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F16;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F17()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F17;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F18()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F18;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F19()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F19;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F20()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F20;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F21()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F21;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F22()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F22;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F23()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F23;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void F24()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.F24;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NUMLOCK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NUMLOCK;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void SCROLL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.SCROLL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LSHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LSHIFT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RSHIFT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RSHIFT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LCONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LCONTROL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RCONTROL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RCONTROL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LMENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LMENU;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void RMENU()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.RMENU;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_BACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_BACK;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_FORWARD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_FORWARD;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_REFRESH()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_REFRESH;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_STOP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_STOP;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_SEARCH()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_SEARCH;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_FAVORITES()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_FAVORITES;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void BROWSER_HOME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.BROWSER_HOME;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_MUTE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_MUTE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_DOWN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_DOWN;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void VOLUME_UP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.VOLUME_UP;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_NEXT_TRACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_NEXT_TRACK;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_PREV_TRACK()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_PREV_TRACK;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_STOP()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_STOP;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void MEDIA_PLAY_PAUSE()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.MEDIA_PLAY_PAUSE;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_MAIL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_MAIL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_MEDIA_SELECT()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_MEDIA_SELECT;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_APP1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_APP1;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void LAUNCH_APP2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.LAUNCH_APP2;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_PLUS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_PLUS;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_COMMA()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_COMMA;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_MINUS()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_MINUS;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_PERIOD()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_PERIOD;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_1;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_2()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_2;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_3()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_3;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_4()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_4;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_5()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_5;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_6()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_6;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_7()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_7;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_8()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_8;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_102()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_102;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PROCESSKEY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PROCESSKEY;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PACKET()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PACKET;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ATTN()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ATTN;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void CRSEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.CRSEL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EXSEL()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EXSEL;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void EREOF()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.EREOF;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PLAY()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PLAY;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void ZOOM()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.ZOOM;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void NONAME()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.NONAME;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void PA1()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.PA1;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void OEM_CLEAR()
            {
                INPUT[] Inputs = new INPUT[1];
                INPUT Input = new INPUT();
                Input.type = 1;
                Input.U.ki.wScan = ScanCodeShort.OEM_CLEAR;
                Input.U.ki.dwFlags = 0;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
                Thread.Sleep(10);
                Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
                Inputs[0] = Input;
                SendInput(1, Inputs, INPUT.Size);
            }

            public static void StringToKey(String keycode)
            {
                switch (keycode)
                {
                    case "LBUTTON":
                        LBUTTON();
                        break;
                    case "RBUTTON":
                        RBUTTON();
                        break;
                    case "CANCEL":
                        CANCEL();
                        break;
                    case "MBUTTON":
                        MBUTTON();
                        break;
                    case "XBUTTON1":
                        XBUTTON1();
                        break;
                    case "XBUTTON2":
                        XBUTTON2();
                        break;
                    case "BACK":
                        BACK();
                        break;
                    case "TAB":
                        TAB();
                        break;
                    case "CLEAR":
                        CLEAR();
                        break;
                    case "RETURN":
                        RETURN();
                        break;
                    case "SHIFT":
                        SHIFT();
                        break;
                    case "CONTROL":
                        CONTROL();
                        break;
                    case "MENU":
                        MENU();
                        break;
                    case "PAUSE":
                        PAUSE();
                        break;
                    case "CAPITAL":
                        CAPITAL();
                        break;
                    case "KANA":
                        KANA();
                        break;
                    case "HANGUL":
                        HANGUL();
                        break;
                    case "JUNJA":
                        JUNJA();
                        break;
                    case "FINAL":
                        FINAL();
                        break;
                    case "HANJA":
                        HANJA();
                        break;
                    case "KANJI":
                        KANJI();
                        break;
                    case "ESCAPE":
                        ESCAPE();
                        break;
                    case "CONVERT":
                        CONVERT();
                        break;
                    case "NONCONVERT":
                        NONCONVERT();
                        break;
                    case "ACCEPT":
                        ACCEPT();
                        break;
                    case "MODECHANGE":
                        MODECHANGE();
                        break;
                    case "SPACE":
                        SPACE();
                        break;
                    case "PRIOR":
                        PRIOR();
                        break;
                    case "NEXT":
                        NEXT();
                        break;
                    case "END":
                        END();
                        break;
                    case "HOME":
                        HOME();
                        break;
                    case "LEFT":
                        LEFT();
                        break;
                    case "UP":
                        UP();
                        break;
                    case "RIGHT":
                        RIGHT();
                        break;
                    case "DOWN":
                        DOWN();
                        break;
                    case "SELECT":
                        SELECT();
                        break;
                    case "PRINT":
                        PRINT();
                        break;
                    case "EXECUTE":
                        EXECUTE();
                        break;
                    case "SNAPSHOT":
                        SNAPSHOT();
                        break;
                    case "INSERT":
                        INSERT();
                        break;
                    case "DELETE":
                        DELETE();
                        break;
                    case "HELP":
                        HELP();
                        break;
                    case "KEY_0":
                        KEY_0();
                        break;
                    case "KEY_1":
                        KEY_1();
                        break;
                    case "KEY_2":
                        KEY_2();
                        break;
                    case "KEY_3":
                        KEY_3();
                        break;
                    case "KEY_4":
                        KEY_4();
                        break;
                    case "KEY_5":
                        KEY_5();
                        break;
                    case "KEY_6":
                        KEY_6();
                        break;
                    case "KEY_7":
                        KEY_7();
                        break;
                    case "KEY_8":
                        KEY_8();
                        break;
                    case "KEY_9":
                        KEY_9();
                        break;
                    case "KEY_A":
                        KEY_A();
                        break;
                    case "KEY_B":
                        KEY_B();
                        break;
                    case "KEY_C":
                        KEY_C();
                        break;
                    case "KEY_D":
                        KEY_D();
                        break;
                    case "KEY_E":
                        KEY_E();
                        break;
                    case "KEY_F":
                        KEY_F();
                        break;
                    case "KEY_G":
                        KEY_G();
                        break;
                    case "KEY_H":
                        KEY_H();
                        break;
                    case "KEY_I":
                        KEY_I();
                        break;
                    case "KEY_J":
                        KEY_J();
                        break;
                    case "KEY_K":
                        KEY_K();
                        break;
                    case "KEY_L":
                        KEY_L();
                        break;
                    case "KEY_M":
                        KEY_M();
                        break;
                    case "KEY_N":
                        KEY_N();
                        break;
                    case "KEY_O":
                        KEY_O();
                        break;
                    case "KEY_P":
                        KEY_P();
                        break;
                    case "KEY_Q":
                        KEY_Q();
                        break;
                    case "KEY_R":
                        KEY_R();
                        break;
                    case "KEY_S":
                        KEY_S();
                        break;
                    case "KEY_T":
                        KEY_T();
                        break;
                    case "KEY_U":
                        KEY_U();
                        break;
                    case "KEY_V":
                        KEY_V();
                        break;
                    case "KEY_W":
                        KEY_W();
                        break;
                    case "KEY_X":
                        KEY_X();
                        break;
                    case "KEY_Y":
                        KEY_Y();
                        break;
                    case "KEY_Z":
                        KEY_Z();
                        break;
                    case "LWIN":
                        LWIN();
                        break;
                    case "RWIN":
                        RWIN();
                        break;
                    case "APPS":
                        APPS();
                        break;
                    case "SLEEP":
                        SLEEP();
                        break;
                    case "NUMPAD0":
                        NUMPAD0();
                        break;
                    case "NUMPAD1":
                        NUMPAD1();
                        break;
                    case "NUMPAD2":
                        NUMPAD2();
                        break;
                    case "NUMPAD3":
                        NUMPAD3();
                        break;
                    case "NUMPAD4":
                        NUMPAD4();
                        break;
                    case "NUMPAD5":
                        NUMPAD5();
                        break;
                    case "NUMPAD6":
                        NUMPAD6();
                        break;
                    case "NUMPAD7":
                        NUMPAD7();
                        break;
                    case "NUMPAD8":
                        NUMPAD8();
                        break;
                    case "NUMPAD9":
                        NUMPAD9();
                        break;
                    case "MULTIPLY":
                        MULTIPLY();
                        break;
                    case "ADD":
                        ADD();
                        break;
                    case "SEPARATOR":
                        SEPARATOR();
                        break;
                    case "SUBTRACT":
                        SUBTRACT();
                        break;
                    case "DECIMAL":
                        DECIMAL();
                        break;
                    case "DIVIDE":
                        DIVIDE();
                        break;
                    case "F1":
                        F1();
                        break;
                    case "F2":
                        F2();
                        break;
                    case "F3":
                        F3();
                        break;
                    case "F4":
                        F4();
                        break;
                    case "F5":
                        F5();
                        break;
                    case "F6":
                        F6();
                        break;
                    case "F7":
                        F7();
                        break;
                    case "F8":
                        F8();
                        break;
                    case "F9":
                        F9();
                        break;
                    case "F10":
                        F10();
                        break;
                    case "F11":
                        F11();
                        break;
                    case "F12":
                        F12();
                        break;
                    case "F13":
                        F13();
                        break;
                    case "F14":
                        F14();
                        break;
                    case "F15":
                        F15();
                        break;
                    case "F16":
                        F16();
                        break;
                    case "F17":
                        F17();
                        break;
                    case "F18":
                        F18();
                        break;
                    case "F19":
                        F19();
                        break;
                    case "F20":
                        F20();
                        break;
                    case "F21":
                        F21();
                        break;
                    case "F22":
                        F22();
                        break;
                    case "F23":
                        F23();
                        break;
                    case "F24":
                        F24();
                        break;
                    case "NUMLOCK":
                        NUMLOCK();
                        break;
                    case "SCROLL":
                        SCROLL();
                        break;
                    case "LSHIFT":
                        LSHIFT();
                        break;
                    case "RSHIFT":
                        RSHIFT();
                        break;
                    case "LCONTROL":
                        LCONTROL();
                        break;
                    case "RCONTROL":
                        RCONTROL();
                        break;
                    case "LMENU":
                        LMENU();
                        break;
                    case "RMENU":
                        RMENU();
                        break;
                    case "BROWSER_BACK":
                        BROWSER_BACK();
                        break;
                    case "BROWSER_FORWARD":
                        BROWSER_FORWARD();
                        break;
                    case "BROWSER_REFRESH":
                        BROWSER_REFRESH();
                        break;
                    case "BROWSER_STOP":
                        BROWSER_STOP();
                        break;
                    case "BROWSER_SEARCH":
                        BROWSER_SEARCH();
                        break;
                    case "BROWSER_FAVORITES":
                        BROWSER_FAVORITES();
                        break;
                    case "BROWSER_HOME":
                        BROWSER_HOME();
                        break;
                    case "VOLUME_MUTE":
                        VOLUME_MUTE();
                        break;
                    case "VOLUME_DOWN":
                        VOLUME_DOWN();
                        break;
                    case "VOLUME_UP":
                        VOLUME_UP();
                        break;
                    case "MEDIA_NEXT_TRACK":
                        MEDIA_NEXT_TRACK();
                        break;
                    case "MEDIA_PREV_TRACK":
                        MEDIA_PREV_TRACK();
                        break;
                    case "MEDIA_STOP":
                        MEDIA_STOP();
                        break;
                    case "MEDIA_PLAY_PAUSE":
                        MEDIA_PLAY_PAUSE();
                        break;
                    case "LAUNCH_MAIL":
                        LAUNCH_MAIL();
                        break;
                    case "LAUNCH_MEDIA_SELECT":
                        LAUNCH_MEDIA_SELECT();
                        break;
                    case "LAUNCH_APP1":
                        LAUNCH_APP1();
                        break;
                    case "LAUNCH_APP2":
                        LAUNCH_APP2();
                        break;
                    case "OEM_1":
                        OEM_1();
                        break;
                    case "OEM_PLUS":
                        OEM_PLUS();
                        break;
                    case "OEM_COMMA":
                        OEM_COMMA();
                        break;
                    case "OEM_MINUS":
                        OEM_MINUS();
                        break;
                    case "OEM_PERIOD":
                        OEM_PERIOD();
                        break;
                    case "OEM_2":
                        OEM_2();
                        break;
                    case "OEM_3":
                        OEM_3();
                        break;
                    case "OEM_4":
                        OEM_4();
                        break;
                    case "OEM_5":
                        OEM_5();
                        break;
                    case "OEM_6":
                        OEM_6();
                        break;
                    case "OEM_7":
                        OEM_7();
                        break;
                    case "OEM_8":
                        OEM_8();
                        break;
                    case "OEM_102":
                        OEM_102();
                        break;
                    case "PROCESSKEY":
                        PROCESSKEY();
                        break;
                    case "PACKET":
                        PACKET();
                        break;
                    case "ATTN":
                        ATTN();
                        break;
                    case "CRSEL":
                        CRSEL();
                        break;
                    case "EXSEL":
                        EXSEL();
                        break;
                    case "EREOF":
                        EREOF();
                        break;
                    case "PLAY":
                        PLAY();
                        break;
                    case "ZOOM":
                        ZOOM();
                        break;
                    case "NONAME":
                        NONAME();
                        break;
                    case "PA1":
                        PA1();
                        break;
                    case "OEM_CLEAR":
                        OEM_CLEAR();
                        break;
                    default:
                        Console.WriteLine("Key Not Found!");
                        break;
                }
            }
        }

        public class Experimental
        {
        }

        [DllImport("user32.dll")]
        internal static extern uint SendInput(
            uint nInputs,
            [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs,
            int cbSize);


        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            internal uint type;
            internal InputUnion U;
            internal static int Size
            {
                get { return Marshal.SizeOf(typeof(INPUT)); }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct InputUnion
        {
            [FieldOffset(0)]
            internal MOUSEINPUT mi;
            [FieldOffset(0)]
            internal KEYBDINPUT ki;
            [FieldOffset(0)]
            internal HARDWAREINPUT hi;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MOUSEINPUT
        {
            internal int dx;
            internal int dy;
            internal MouseEventDataXButtons mouseData;
            internal MOUSEEVENTF dwFlags;
            internal uint time;
            internal UIntPtr dwExtraInfo;
        }

        [Flags]
        internal enum MouseEventDataXButtons : uint
        {
            Nothing = 0x00000000,
            XBUTTON1 = 0x00000001,
            XBUTTON2 = 0x00000002
        }

        [Flags]
        internal enum MOUSEEVENTF : uint
        {
            ABSOLUTE = 0x8000,
            HWHEEL = 0x01000,
            MOVE = 0x0001,
            MOVE_NOCOALESCE = 0x2000,
            LEFTDOWN = 0x0002,
            LEFTUP = 0x0004,
            RIGHTDOWN = 0x0008,
            RIGHTUP = 0x0010,
            MIDDLEDOWN = 0x0020,
            MIDDLEUP = 0x0040,
            VIRTUALDESK = 0x4000,
            WHEEL = 0x0800,
            XDOWN = 0x0080,
            XUP = 0x0100
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct KEYBDINPUT
        {
            internal VirtualKeyShort wVk;
            internal ScanCodeShort wScan;
            internal KEYEVENTF dwFlags;
            internal int time;
            internal UIntPtr dwExtraInfo;
        }

        [Flags]
        internal enum KEYEVENTF : uint
        {
            EXTENDEDKEY = 0x0001,
            KEYUP = 0x0002,
            SCANCODE = 0x0008,
            UNICODE = 0x0004
        }

        internal enum VirtualKeyShort : short
        {
            LBUTTON = 0x01,
            RBUTTON = 0x02,
            CANCEL = 0x03,
            MBUTTON = 0x04,
            XBUTTON1 = 0x05,
            XBUTTON2 = 0x06,
            BACK = 0x08,
            TAB = 0x09,
            CLEAR = 0x0C,
            RETURN = 0x0D,
            SHIFT = 0x10,
            CONTROL = 0x11,
            MENU = 0x12,
            PAUSE = 0x13,
            CAPITAL = 0x14,
            KANA = 0x15,
            HANGUL = 0x15,
            JUNJA = 0x17,
            FINAL = 0x18,
            HANJA = 0x19,
            KANJI = 0x19,
            ESCAPE = 0x1B,
            CONVERT = 0x1C,
            NONCONVERT = 0x1D,
            ACCEPT = 0x1E,
            MODECHANGE = 0x1F,
            SPACE = 0x20,
            PRIOR = 0x21,
            NEXT = 0x22,
            END = 0x23,
            HOME = 0x24,
            LEFT = 0x25,
            UP = 0x26,
            RIGHT = 0x27,
            DOWN = 0x28,
            SELECT = 0x29,
            PRINT = 0x2A,
            EXECUTE = 0x2B,
            SNAPSHOT = 0x2C,
            INSERT = 0x2D,
            DELETE = 0x2E,
            HELP = 0x2F,
            KEY_0 = 0x30,
            KEY_1 = 0x31,
            KEY_2 = 0x32,
            KEY_3 = 0x33,
            KEY_4 = 0x34,
            KEY_5 = 0x35,
            KEY_6 = 0x36,
            KEY_7 = 0x37,
            KEY_8 = 0x38,
            KEY_9 = 0x39,
            KEY_A = 0x41,
            KEY_B = 0x42,
            KEY_C = 0x43,
            KEY_D = 0x44,
            KEY_E = 0x45,
            KEY_F = 0x46,
            KEY_G = 0x47,
            KEY_H = 0x48,
            KEY_I = 0x49,
            KEY_J = 0x4A,
            KEY_K = 0x4B,
            KEY_L = 0x4C,
            KEY_M = 0x4D,
            KEY_N = 0x4E,
            KEY_O = 0x4F,
            KEY_P = 0x50,
            KEY_Q = 0x51,
            KEY_R = 0x52,
            KEY_S = 0x53,
            KEY_T = 0x54,
            KEY_U = 0x55,
            KEY_V = 0x56,
            KEY_W = 0x57,
            KEY_X = 0x58,
            KEY_Y = 0x59,
            KEY_Z = 0x5A,
            LWIN = 0x5B,
            RWIN = 0x5C,
            APPS = 0x5D,
            SLEEP = 0x5F,
            NUMPAD0 = 0x60,
            NUMPAD1 = 0x61,
            NUMPAD2 = 0x62,
            NUMPAD3 = 0x63,
            NUMPAD4 = 0x64,
            NUMPAD5 = 0x65,
            NUMPAD6 = 0x66,
            NUMPAD7 = 0x67,
            NUMPAD8 = 0x68,
            NUMPAD9 = 0x69,
            MULTIPLY = 0x6A,
            ADD = 0x6B,
            SEPARATOR = 0x6C,
            SUBTRACT = 0x6D,
            DECIMAL = 0x6E,
            DIVIDE = 0x6F,
            F1 = 0x70,
            F2 = 0x71,
            F3 = 0x72,
            F4 = 0x73,
            F5 = 0x74,
            F6 = 0x75,
            F7 = 0x76,
            F8 = 0x77,
            F9 = 0x78,
            F10 = 0x79,
            F11 = 0x7A,
            F12 = 0x7B,
            F13 = 0x7C,
            F14 = 0x7D,
            F15 = 0x7E,
            F16 = 0x7F,
            F17 = 0x80,
            F18 = 0x81,
            F19 = 0x82,
            F20 = 0x83,
            F21 = 0x84,
            F22 = 0x85,
            F23 = 0x86,
            F24 = 0x87,
            NUMLOCK = 0x90,
            SCROLL = 0x91,
            LSHIFT = 0xA0,
            RSHIFT = 0xA1,
            LCONTROL = 0xA2,
            RCONTROL = 0xA3,
            LMENU = 0xA4,
            RMENU = 0xA5,
            BROWSER_BACK = 0xA6,
            BROWSER_FORWARD = 0xA7,
            BROWSER_REFRESH = 0xA8,
            BROWSER_STOP = 0xA9,
            BROWSER_SEARCH = 0xAA,
            BROWSER_FAVORITES = 0xAB,
            BROWSER_HOME = 0xAC,
            VOLUME_MUTE = 0xAD,
            VOLUME_DOWN = 0xAE,
            VOLUME_UP = 0xAF,
            MEDIA_NEXT_TRACK = 0xB0,
            MEDIA_PREV_TRACK = 0xB1,
            MEDIA_STOP = 0xB2,
            MEDIA_PLAY_PAUSE = 0xB3,
            LAUNCH_MAIL = 0xB4,
            LAUNCH_MEDIA_SELECT = 0xB5,
            LAUNCH_APP1 = 0xB6,
            LAUNCH_APP2 = 0xB7,
            OEM_1 = 0xBA,
            OEM_PLUS = 0xBB,
            OEM_COMMA = 0xBC,
            OEM_MINUS = 0xBD,
            OEM_PERIOD = 0xBE,
            OEM_2 = 0xBF,
            OEM_3 = 0xC0,
            OEM_4 = 0xDB,
            OEM_5 = 0xDC,
            OEM_6 = 0xDD,
            OEM_7 = 0xDE,
            OEM_8 = 0xDF,
            OEM_102 = 0xE2,
            PROCESSKEY = 0xE5,
            PACKET = 0xE7,
            ATTN = 0xF6,
            CRSEL = 0xF7,
            EXSEL = 0xF8,
            EREOF = 0xF9,
            PLAY = 0xFA,
            ZOOM = 0xFB,
            NONAME = 0xFC,
            PA1 = 0xFD,
            OEM_CLEAR = 0xFE
        }

        internal enum ScanCodeShort : short
        {
            LBUTTON = 0,
            RBUTTON = 0,
            CANCEL = 70,
            MBUTTON = 0,
            XBUTTON1 = 0,
            XBUTTON2 = 0,
            BACK = 14,
            TAB = 15,
            CLEAR = 76,
            RETURN = 28,
            SHIFT = 42,
            CONTROL = 29,
            MENU = 56,
            PAUSE = 0,
            CAPITAL = 58,
            KANA = 0,
            HANGUL = 0,
            JUNJA = 0,
            FINAL = 0,
            HANJA = 0,
            KANJI = 0,
            ESCAPE = 1,
            CONVERT = 0,
            NONCONVERT = 0,
            ACCEPT = 0,
            MODECHANGE = 0,
            SPACE = 57,
            PRIOR = 73,
            NEXT = 81,
            END = 79,
            HOME = 71,
            LEFT = 75,
            UP = 72,
            RIGHT = 77,
            DOWN = 80,
            SELECT = 0,
            PRINT = 0,
            EXECUTE = 0,
            SNAPSHOT = 84,
            INSERT = 82,
            DELETE = 83,
            HELP = 99,
            KEY_0 = 11,
            KEY_1 = 2,
            KEY_2 = 3,
            KEY_3 = 4,
            KEY_4 = 5,
            KEY_5 = 6,
            KEY_6 = 7,
            KEY_7 = 8,
            KEY_8 = 9,
            KEY_9 = 10,
            KEY_A = 30,
            KEY_B = 48,
            KEY_C = 46,
            KEY_D = 32,
            KEY_E = 18,
            KEY_F = 33,
            KEY_G = 34,
            KEY_H = 35,
            KEY_I = 23,
            KEY_J = 36,
            KEY_K = 37,
            KEY_L = 38,
            KEY_M = 50,
            KEY_N = 49,
            KEY_O = 24,
            KEY_P = 25,
            KEY_Q = 16,
            KEY_R = 19,
            KEY_S = 31,
            KEY_T = 20,
            KEY_U = 22,
            KEY_V = 47,
            KEY_W = 17,
            KEY_X = 45,
            KEY_Y = 21,
            KEY_Z = 44,
            LWIN = 91,
            RWIN = 92,
            APPS = 93,
            SLEEP = 95,
            NUMPAD0 = 82,
            NUMPAD1 = 79,
            NUMPAD2 = 80,
            NUMPAD3 = 81,
            NUMPAD4 = 75,
            NUMPAD5 = 76,
            NUMPAD6 = 77,
            NUMPAD7 = 71,
            NUMPAD8 = 72,
            NUMPAD9 = 73,
            MULTIPLY = 55,
            ADD = 78,
            SEPARATOR = 0,
            SUBTRACT = 74,
            DECIMAL = 83,
            DIVIDE = 53,
            F1 = 59,
            F2 = 60,
            F3 = 61,
            F4 = 62,
            F5 = 63,
            F6 = 64,
            F7 = 65,
            F8 = 66,
            F9 = 67,
            F10 = 68,
            F11 = 87,
            F12 = 88,
            F13 = 100,
            F14 = 101,
            F15 = 102,
            F16 = 103,
            F17 = 104,
            F18 = 105,
            F19 = 106,
            F20 = 107,
            F21 = 108,
            F22 = 109,
            F23 = 110,
            F24 = 118,
            NUMLOCK = 69,
            SCROLL = 70,
            LSHIFT = 42,
            RSHIFT = 54,
            LCONTROL = 29,
            RCONTROL = 29,
            LMENU = 56,
            RMENU = 56,
            BROWSER_BACK = 106,
            BROWSER_FORWARD = 105,
            BROWSER_REFRESH = 103,
            BROWSER_STOP = 104,
            BROWSER_SEARCH = 101,
            BROWSER_FAVORITES = 102,
            BROWSER_HOME = 50,
            VOLUME_MUTE = 32,
            VOLUME_DOWN = 46,
            VOLUME_UP = 48,
            MEDIA_NEXT_TRACK = 25,
            MEDIA_PREV_TRACK = 16,
            MEDIA_STOP = 36,
            MEDIA_PLAY_PAUSE = 34,
            LAUNCH_MAIL = 108,
            LAUNCH_MEDIA_SELECT = 109,
            LAUNCH_APP1 = 107,
            LAUNCH_APP2 = 33,
            OEM_1 = 39,
            OEM_PLUS = 13,
            OEM_COMMA = 51,
            OEM_MINUS = 12,
            OEM_PERIOD = 52,
            OEM_2 = 53,
            OEM_3 = 41,
            OEM_4 = 26,
            OEM_5 = 43,
            OEM_6 = 27,
            OEM_7 = 40,
            OEM_8 = 0,
            OEM_102 = 86,
            PROCESSKEY = 0,
            PACKET = 0,
            ATTN = 0,
            CRSEL = 0,
            EXSEL = 0,
            EREOF = 93,
            PLAY = 0,
            ZOOM = 98,
            NONAME = 0,
            PA1 = 0,
            OEM_CLEAR = 0,
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct HARDWAREINPUT
        {
            internal int uMsg;
            internal short wParamL;
            internal short wParamH;
        }
    }
}
