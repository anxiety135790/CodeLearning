namespace Packt.Shared
{
    public struct DisplacementVector
    {
        public int x;
        public int y;

        public DisplacementVector(int inigialX, int initialY)
        {
            x = initialX;
            y = initialY;

        }

        public static DisplacementVector operator +(
            DisplacementVector vector1,
            DisplacementVector vectro2)
        {
            return new(
                vector.X + vector2.x,
                vector.Y + vector2.Y);
        }

    }
}
