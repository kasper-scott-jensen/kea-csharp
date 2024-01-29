namespace classes2;

public class Donald : Duck
{
    
    public bool IsMainChar { get; set; }
    public string OutfitColor { get; set; }

    public Donald(string name, int age, string gender, bool isDomestic, bool isMainChar, string outfitColor)
        : base(name, age, gender, isDomestic)
    {
        IsMainChar = isMainChar;
        OutfitColor = outfitColor;
    }
    
}