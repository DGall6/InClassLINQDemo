using System.Text.Json;

// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());

//display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }
// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");

// how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");

// which characters were created in 1995
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//   Console.WriteLine(characterDTO.Display());
// }

// how many characters in total (all series)?
// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");
// how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {MarioCount} characters in the Mario series");
// how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
// how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
// which characters (name only) appear in Mario and Donkey Kong?
// foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
// how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");

// which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }
// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
// which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
// all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
// foreach(var characterByYearCreated in CharactersByYearCreated)
// {
//   Console.WriteLine(characterByYearCreated.Key);
//   foreach(var character in characterByYearCreated) {
//     Console.WriteLine($"\t{character.Name}");
//   }
// }

//**************//
//BEGIN HOMEWORK//
//**************//

// [1.19a] How many character(s) were created in 1981 (all series)?
Console.WriteLine("[1.19a]");
Console.WriteLine($"How many character(s) were created in 1981? {characters.Count(c => c.YearCreated == 1981)}");

// [1.19b] List the character(s) created in that 1981 (all series) - return character name and series only.
Console.WriteLine("[1.19b]");
foreach (var obj in characters.Where(c => c.YearCreated == 1981).Select(c => new { c.Name, c.Description}))
{
    Console.WriteLine($"{obj.Name} - {obj.Description}");
}

// [1.19c] How many character(s) were created in 1981 (Mario series)?
Console.WriteLine("[1.19c]");
Console.WriteLine($"How many character(s) were created in 1981 in Mario? {characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Count()}");

// [1.19d] List the character(s) created in that 1981 (Mario series) - return character name only.
Console.WriteLine("[1.19d]");
foreach (String? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Select(c => c.Name))
{
    Console.WriteLine(name);
}

// [1.19e] How many character(s) were created in 1981 (Donkey Kong series)?
Console.WriteLine("[1.19e]");
Console.WriteLine($"How many character(s) were created in 1981 in Donkey Kong? {characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Count()}");

// [1.19f] List the character(s) created in that 1981 (Donkey Kong series) - return character name only.
Console.WriteLine("[1.19f]");
foreach (String? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Select(c => c.Name))
{
    Console.WriteLine(name);
}

// [1.20a] How many character(s) made their first appearance in Donkey Kong 64?
Console.WriteLine("[1.20a]");
Console.WriteLine($"How many characters made their first appearance in DK 64? {characters.Where(c => c.FirstAppearance!.Contains("Donkey Kong 64")).Count()}");

// [1.20b] List the character(s) that made their first appearance in Donkey Kong 64 - return character name only.
Console.WriteLine("[1.20b]");
foreach (String? name in characters.Where(c => c.FirstAppearance!.Contains("Donkey Kong 64")).Select(c => c.Name))
{
    Console.WriteLine(name);
}

// [1.21a] Are there any character(s) with no alias (all series)?
Console.WriteLine("[1.21a]");
bool checkAlias = characters.Exists(c => c.Alias.Count == 0);
Console.WriteLine($"Are there any characters with no alias? {checkAlias}");

// [1.21b] How many character(s) with no alias (all series)?
Console.WriteLine("[1.21b]");
Console.WriteLine($"How many characters have no alias? {characters.Where(c => c.Alias.Count == 0).Count()}");

// [1.21c] List the character(s) with no alias (all series) - return character name, alias and series only.
Console.WriteLine("[1.21c]");
foreach (var obj in characters.Where(c => c.Alias.Count == 0).Select(c => new {c.Name, c.Alias, c.Series}))
{
    // Doesn't print right since there are no alias's, but the prompt said to include alias in return
    Console.WriteLine($"{obj.Name} - {String.Join(", ", obj.Alias)} - {String.Join(", ", obj.Series)}");
}

// [1.21d] Are there any character(s) with no alias (Mario)?
Console.WriteLine("[1.21d]");
bool checkMarioAlias = characters.Exists(c => c.Alias.Count == 0 && c.Series.Contains("Mario"));
Console.WriteLine($"Are there any Mario characters with no alias? {checkMarioAlias}");

// [1.21e] How many character(s) with no alias (Mario)?
Console.WriteLine("[1.21e]");
Console.WriteLine($"How many Mario characters have no alias? {characters.Where(c => c.Alias.Count == 0 && c.Series.Contains("Mario")).Count()}");

// [1.21f] List the character(s) with no alias Mario) - return character name, alias and series only.
Console.WriteLine("[1.21f]");
foreach (var obj in characters.Where(c => c.Alias.Count == 0 && c.Series.Contains("Mario")).Select(c => new {c.Name, c.Alias}))
{
    // Doesn't print right since there are no alias's, but the prompt said to include alias in return
    Console.WriteLine($"{obj.Name} - {String.Join(", ", obj.Alias)}");
}

// [1.21g] Are there any character(s) with no alias (DK)?
Console.WriteLine("[1.21g]");
bool checkDKAlias = characters.Exists(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong"));
Console.WriteLine($"Are there any DK characters with no alias? {checkDKAlias}");

// [1.21h] How many character(s) with no alias (DK)?
Console.WriteLine("[1.21h]");
Console.WriteLine($"How many DK characters have no alias? {characters.Where(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong")).Count()}");

// [1.21i] List the character(s) with no alias (DK) - return character name, alias and series only.
Console.WriteLine("[1.21i]");
foreach (var obj in characters.Where(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong")).Select(c => new {c.Name, c.Alias}))
{
    // Doesn't print right since there are no alias's, but the prompt said to include alias in return
    Console.WriteLine($"{obj.Name} - {String.Join(", ", obj.Alias)}");
}

// [1.22a] Do any character(s) have an alias of Snowmad King (return type must be boolean)?
Console.WriteLine("[1.22a]");
bool snowmadKing = characters.Exists(c => c.Alias.Contains("Snowmad King"));
Console.WriteLine($"Do any characters have an alias of Snowmad King? {snowmadKing}");

// [1.22b] List the character(s) that have an alias of Snowmad King - return character name and alias only.
Console.WriteLine("[1.22b]");
foreach (var obj in characters.Where(c => c.Alias.Contains("Snowmad King")).Select(c => new {c.Name, c.Alias}))
{
    Console.WriteLine($"{obj.Name} - {String.Join(", ", obj.Alias)}");
}

// [1.23a] Do any character(s) that have an alias of Winter Kong (return type must be boolean)?
Console.WriteLine("[1.23a]");
bool winterKong = characters.Exists(c => c.Alias.Contains("Winter Kong"));
Console.WriteLine($"Do any characters have an alias of Winter Kong? {winterKong}");

// [1.23b] List the character(s) that have an alias of Winter Kong - return character name and alias only.
Console.WriteLine("[1.23b]");
foreach (var obj in characters.Where(c => c.Alias.Contains("Winter Kong")).Select(c => new {c.Name, c.Alias}))
{
    // Doesn't output anything since there are no characters with this alias
    Console.WriteLine($"{obj.Name} - {String.Join(", ", obj.Alias)}");
}

// [1.24a] How many character(s) have a species of Kremling?
Console.WriteLine("[1.24a]");
Console.WriteLine($"How many characters have a species of Kremling? {characters.Where(c => c.Species == "Kremling").Count()}");

// [1.24b] List the character(s) that have a species of Kremling - return character name only.
Console.WriteLine("[1.24b]");
foreach (String? name in characters.Where(c => c.Species == "Kremling").Select(c => c.Name))
{
    Console.WriteLine(name);
}

// [1.25a] How many character(s) in the Mario series are Human species?
Console.WriteLine("[1.25a]");
Console.WriteLine($"How many Mario characters have a species of Human? {characters.Where(c => c.Species == "Human" && c.Series.Contains("Mario")).Count()}");

// [1.25b] List the character(s) in the Mario series that are Human species - return character name only.
Console.WriteLine("[1.25b]");
foreach (String? name in characters.Where(c => c.Species == "Human" && c.Series.Contains("Mario")).Select(c => c.Name))
{
    Console.WriteLine(name);
}

// [1.25c] How many character(s) in the Mario series are Koopa species?
Console.WriteLine("[1.25c]");
Console.WriteLine($"How many Mario characters have a species of Koopa? {characters.Where(c => c.Species == "Koopa" && c.Series.Contains("Mario")).Count()}");

// [1.25d] List the character(s) in the Mario series that are Koopa species - return character name only.
Console.WriteLine("[1.25d]");
foreach (String? name in characters.Where(c => c.Species == "Koopa" && c.Series.Contains("Mario")).Select(c => c.Name))
{
    Console.WriteLine(name);
}

// [1.25e] How many character(s) in the Mario series are something other than Human or Koopa species?
Console.WriteLine("[1.25e]");
Console.WriteLine($"How many Mario characters are something other than Humans or Koopas? {characters.Where(c => !(c.Species == "Koopa" || c.Species == "Human") && c.Series.Contains("Mario")).Count()}");

// [1.25f] List the character(s) in the Mario series that are something other than Human or Koopa species - return character name and species only.
Console.WriteLine("[1.25f]");
foreach (var obj in characters.Where(c => !(c.Species == "Koopa" || c.Species == "Human") && c.Series.Contains("Mario")).Select(c => new {c.Name, c.Species}))
{
    Console.WriteLine($"{obj.Name} - {obj.Species}");
}