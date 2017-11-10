
namespace Core.JSON.WebToken.Algorithms
{
    public interface IHashAlgorithm
    {
        string Name 
        { 
            get; 
        }

        byte[] GenerateSignature(byte[] data, byte[] key);
    }
}