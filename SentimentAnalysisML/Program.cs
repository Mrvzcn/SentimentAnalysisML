using Microsoft.ML;

class Program
{
    static void Main()
    {
        // 1 - ML Context oluştur
        var mlContext = new MLContext();

        // 2 - Veri setini oku
        var data = mlContext.Data.LoadFromTextFile<SentimentData>(
            path: "sentiment-data.csv",
            hasHeader: true,
            separatorChar: ',');

        // 3 - Pipeline oluştur
        var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", nameof(SentimentData.Text))
            .Append(mlContext.Transforms.Conversion.MapValueToKey("Label"))
            .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy())
            .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

        // 4 - Modeli eğit
        Console.WriteLine("Model eğitiliyor...");
        var model = pipeline.Fit(data);
        Console.WriteLine("Model eğitildi!");

        // 5 - Prediction Engine oluştur
        var predictor = mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(model);

        // 6 - Kullanıcıdan cümle al
        Console.WriteLine("\nBir cümle yazın:");
        string input = Console.ReadLine();

        var result = predictor.Predict(new SentimentData { Text = input });

        Console.WriteLine($"\nTahmin edilen duygu: {result.PredictedLabel}");
    }
}
