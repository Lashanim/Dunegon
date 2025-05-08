
interface IMoveable
{
    void Move(IMoveable.ERichtung richtung);

        enum ERichtung
        {
        ENone,
        EForward,
        EBackward,
        ERight,
        ELeft
        }
}