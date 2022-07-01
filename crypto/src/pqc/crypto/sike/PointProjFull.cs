namespace Org.Bouncycastle.Pqc.Crypto.Sike
{


public class PointProjFull
{
    internal PointProjFull(uint nwords_field)
    {
        X = Utils.InitArray(2, nwords_field);
        Y = Utils.InitArray(2, nwords_field);
        Z = Utils.InitArray(2, nwords_field);
    }
    public ulong[][] X;
    public ulong[][] Y;
    public ulong[][] Z;
}

}