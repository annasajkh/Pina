﻿namespace Testbed.Abstractions
{
    public readonly struct KeyInputEventArgs
    {
        public readonly KeyCodes Key;

        public readonly KeyModifiers Modifiers;

        public readonly bool IsRepeat;

        public bool Alt => Modifiers.HasFlag(KeyModifiers.Alt);

        public bool Control => Modifiers.HasFlag(KeyModifiers.Control);

        public bool Shift => Modifiers.HasFlag(KeyModifiers.Shift);

        public bool Command => Modifiers.HasFlag(KeyModifiers.Super);

        public KeyInputEventArgs(KeyCodes key, KeyModifiers modifiers, bool isRepeat)
        {
            Key = key;
            Modifiers = modifiers;
            IsRepeat = isRepeat;
        }
    }
}