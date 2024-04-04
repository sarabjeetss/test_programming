// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from Sarab"
// Define discriminated union for genre
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

// Define record for director
type Director = {
    Name: string
    Movies: int
}

// Define record for movie
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDbRating: float
}

// Create instances of Genre
let horror = Horror
let drama = Drama
let thriller = Thriller
let comedy = Comedy
let fantasy = Fantasy
let sport = Sport

// Create instances of Director
let sianHeder = { Name = "Sian Heder"; Movies = 9 }
let kennethBranagh = { Name = "Kenneth Branagh"; Movies = 23 }
let adamMckay = { Name = "Adam McKay"; Movies = 27 }
let ryusukeHamaguchi = { Name = "Ryusuke Hamaguchi"; Movies = 16 }
let denisVilleneuve = { Name = "Denis Villeneuve"; Movies = 24 }
let reinaldoMarcusGreen = { Name = "Reinaldo Marcus Green"; Movies = 15 }
let paulThomasAnderson = { Name = "Paul Thomas Anderson"; Movies = 49 }
let guillermoDelToro = { Name = "Guillermo Del Toro"; Movies = 22 }

// Create instances of Movie
let movies = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = sianHeder; IMDbRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = kennethBranagh; IMDbRating = 7.3 }
    { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = adamMckay; IMDbRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = ryusukeHamaguchi; IMDbRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = denisVilleneuve; IMDbRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = reinaldoMarcusGreen; IMDbRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = paulThomasAnderson; IMDbRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = guillermoDelToro; IMDbRating = 7.1 }
]

// Identify probable Oscar winners
let probableWinners = List.filter (fun movie -> movie.IMDbRating > 7.4) movies

// Convert run length to hours and minutes format
let convertRunLength runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let convertedRunLengths = List.map (fun movie -> convertRunLength movie.RunLength) movies

// Print probable Oscar winners
printfn "Probable Oscar Winners:"
List.iter (fun movie -> printfn "- %s" movie.Name) probableWinners

// Print converted run lengths
printfn "\nConverted Run Lengths:"
List.iter2 (fun movie convertedRunLength -> printfn "%s: %s" movie.Name convertedRunLength) movies convertedRunLengths


