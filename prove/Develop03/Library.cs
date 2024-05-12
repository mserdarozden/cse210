public class Library
{
    private List<Reference> _references = new List<Reference>();
    private List<string> _scriptureText = new List<string>();

    private int _randomNumber;

    public Library()
    {
       _references.Add(new Reference("John", 3, 2, 3));
       _references.Add(new Reference("Nephi", 31, 20));
       _references.Add(new Reference("Ether", 12, 32));
       _references.Add(new Reference("Peter", 1, 3));
       _references.Add(new Reference("Alma", 40, 23));
       _references.Add(new Reference("Moroni", 7, 41));
       _references.Add(new Reference("Corinthians", 13, 13));
       _references.Add(new Reference("Hebrews", 11, 1));
       _references.Add(new Reference("Alma", 32, 21));
       _references.Add(new Reference("Moroni", 7, 42, 43));

       _scriptureText.Add("Beloved, now are we the sons of God, and it doth not yet appear what we shall be: but we know that, when he shall appear, we shall be like him; for we shall see him as he is. And every man that hath this hope in him purifieth himself, even as he is pure.");
       _scriptureText.Add("Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");
       _scriptureText.Add("And I also remember that thou hast said that thou hast prepared a house for man, yea, even among the mansions of thy Father, in which man might have a more excellent hope; wherefore man must hope, or he cannot receive an inheritance in the place which thou hast prepared.");
       _scriptureText.Add("Blessed be the God and Father of our Lord Jesus Christ, which according to his abundant mercy hath begotten us again unto a lively hope by the resurrection of Jesus Christ from the dead,");
       _scriptureText.Add("The soul shall be restored to the body, and the body to the soul; yea, and every limb and joint shall be restored to its body; yea, even a hair of the head shall not be lost; but all things shall be restored to their proper and perfect frame.");
       _scriptureText.Add("And what is it that ye shall hope for? Behold I say unto you that ye shall have hope through the atonement of Christ and the power of his resurrection, to be raised unto life eternal, and this because of your faith in him according to the promise.");
       _scriptureText.Add("And now abideth faith, hope, charity, these three; but the greatest of these is charity.");
       _scriptureText.Add("Now faith is the substance of things hoped for, the evidence of things not seen.");
       _scriptureText.Add("And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
       _scriptureText.Add("Wherefore, if a man have faith he must needs have hope; for without faith there cannot be any hope. And again, behold I say unto you that he cannot have faith and hope, save he shall be meek, and lowly of heart.");
    
        Random random = new Random();
        _randomNumber = random.Next(1, 10);
    }

    public Reference getRandomReference()
    {
        return _references[_randomNumber];
    }

    public string GetRandomText()
    {
        return _scriptureText[_randomNumber];
    }
}