
namespace Veriff.net.Shared
{
    public enum ContextType
    {
        DocumentFront,
        DocumentBack,
        Face
    }

    public static class ContextTypeExtensions
    {
        public static string ToContextString(this ContextType contextType)
        {
            switch (contextType)
            {
                case ContextType.DocumentFront:
                    return "document-front";
                case ContextType.DocumentBack:
                    return "document-back";
                case ContextType.Face:
                    return "face";
                default:
                    throw new ArgumentOutOfRangeException(nameof(contextType), contextType, null);
            }
        }
    }
}
