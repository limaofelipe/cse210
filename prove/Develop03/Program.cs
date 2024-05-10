using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {

        HttpClient client = new HttpClient();
        string scriptureApiUrl = "https://bible-api.com/?random=verse"; // Replace with your API URL

        HttpResponseMessage response = await client.GetAsync(scriptureApiUrl);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
        

        var options = new JsonSerializerOptions
        {
        PropertyNameCaseInsensitive = true,
        };

        ApiResponse apiResponse = JsonSerializer.Deserialize<ApiResponse>(responseBody, options);


        Console.WriteLine(apiResponse);
        // Parse the JSON response body here
        // This will depend on the structure of your API response
        string reference = apiResponse.Reference; // Replace with code to parse reference from responseBody
        // string text = apiResponse.Verses[0].Text; // Replace with code to parse text from responseBody
        string text = apiResponse.Verses[0].Text; // Replace with code to parse text from responseBody

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.ToString());
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden.");
                Console.ReadKey();
                break;
            }
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");           
            // ConsoleKeyInfo keyInfo = Console.ReadKey();
            // if (keyInfo.Key == ConsoleKey.Q)
            //     break;
            // else if (keyInfo.Key == ConsoleKey.Enter)
            //     scripture.HideRandomWord();
                       
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            else if (string.IsNullOrEmpty(input))
                scripture.HideRandomWord();
        }
    }
}


public class ApiResponse
{
    public string Reference { get; set; }
    public List<VerseItem> Verses { get; set; }
    public string Text { get; set; }
    [JsonPropertyName("translation_id")]
    public string TranslationId { get; set; }
    [JsonPropertyName("translation_name")]
    public string TranslationName { get; set; }
    
    [JsonPropertyName("translation_note")]
    public string TranslationNote { get; set; }
}

public class VerseItem
{
    [JsonPropertyName("book_id")]
    public string BookId { get; set; }
    [JsonPropertyName("book_name")]
    public string BookName { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }
    public string Text { get; set; }
}

class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = Words.Where(word => !word.IsHidden && !string.IsNullOrWhiteSpace(word.Text)).ToList();
        if (visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference.ToString()}\n{string.Join(" ", Words)}";
    }
}

class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int VerseStart { get; set; }
    public int? VerseEnd { get; set; }

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        Book = parts[0];
        string[] verses = parts[1].Split(':');
        Chapter = int.Parse(verses[0]);
        if (verses[1].Contains('-'))
        {
            string[] range = verses[1].Split('-');
            VerseStart = int.Parse(range[0]);
            VerseEnd = int.Parse(range[1]);
        }
        else
        {
            VerseStart = int.Parse(verses[1]);
        }
    }

    public override string ToString()
    {
        return VerseEnd.HasValue ? $"{Book} {Chapter}:{VerseStart}-{VerseEnd}" : $"{Book} {Chapter}:{VerseStart}";
    }
}

class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Text;
    }
}
