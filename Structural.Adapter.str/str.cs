using System;
using System.Collections;
using System.Text;
using JetBrains.Annotations;

namespace Structural.Adapter.str
{
    public class str : IEquatable<str>, IEquatable<string>
    {
        [NotNull] protected readonly byte[] buffer;

        public str()
        {
            buffer = new byte[]{};
        }
    
        public str(string s)
        {
            buffer = Encoding.ASCII.GetBytes(s);
        }
    
        protected str(byte[] buffer)
        {
            this.buffer = buffer;
        }

        public char this[int index]
        {
            get => (char) buffer[index];
            set => buffer[index] = (byte) value;
        }

        public bool Equals(str other)
        {
            if (other == null) return false;
            return ((IStructuralEquatable)buffer)
                .Equals(other.buffer, 
                    StructuralComparisons.StructuralEqualityComparer);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((str) obj);
        }

        public static bool operator ==(str left, str right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(str left, str right)
        {
            return !Equals(left, right);
        }

        // state space explosion here
        public static str operator +(str first, str second)
        {
            byte[] bytes = new byte[first.buffer.Length + second.buffer.Length];
            first.buffer.CopyTo(bytes, 0);
            second.buffer.CopyTo(bytes, first.buffer.Length);
            return new str(bytes);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

    

        public static implicit operator str(string s)
        {
            return new str(s);
        }

        public bool Equals(string other)
        {
            return ToString().Equals(other);
        }

        public override string ToString()
        {
            return Encoding.ASCII.GetString(buffer);
        }
    }
}