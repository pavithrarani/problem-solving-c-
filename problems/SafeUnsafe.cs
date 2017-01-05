namespace problems
{
    public class SafeUnsafe
    {
        public bool split(string patt, int jmp)
        {
            if ((patt.Length == 1) && (patt[0] == 'S'))
                return true;

            if (patt[0] == 'U')
                return false;

            if (patt.Length > 0)
            {
                var left = false;
                var right = false;
                var center = false;
                if (jmp > 1)
                {
                    var endLenLeft = patt.Length - (jmp - 1);
                    if (endLenLeft > 0)
                        left = split(patt.Substring(jmp - 1, endLenLeft), jmp - 1);
                }
                var endLenCenter = patt.Length - jmp;
                if (endLenCenter > 0)
                    center = split(patt.Substring(jmp, endLenCenter), jmp);

                var endLenRight = patt.Length - (jmp + 1);
                if (endLenRight > 0)
                    right = split(patt.Substring(jmp + 1, endLenRight), jmp + 1);

                return left || center || right;
            }
            return false;
        }
    }
}
