using Completor.Core.Entities;

namespace Completor.Core.Tools
{
    public interface IParser
    {
        WordSet Parse(string[] text);
    }
}