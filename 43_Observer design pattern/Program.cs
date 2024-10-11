// Creating the observers
var bitcoinPriceReader = new BitCoinPriceReader();

var emailNotifier = new EmailPriceChangeNotifier(2500);
bitcoinPriceReader.AttachObserver(emailNotifier);

var pushNotifier = new PushPriceChangeNotifier(4000);
bitcoinPriceReader.AttachObserver(pushNotifier);

Console.WriteLine("- - First bitcoin price change - -");
bitcoinPriceReader.ReadCurrentPrice();

Console.WriteLine();

Console.WriteLine("- - Second bitcoin price change - -");
bitcoinPriceReader.ReadCurrentPrice();
Console.WriteLine(
    );
// If you want to get read of notifications
Console.WriteLine("- - - Detaching the email notifications - - -");
bitcoinPriceReader.DetachObserver(emailNotifier);
Console.WriteLine("Emails DETACHED");
bitcoinPriceReader.ReadCurrentPrice();
