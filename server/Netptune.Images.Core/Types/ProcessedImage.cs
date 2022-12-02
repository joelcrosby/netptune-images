namespace Netptune.Images.Core.Types;

public record ProcessedImage
{
    public required Stream Content { get; init; }

    public required string ContentType { get; init; }
}
