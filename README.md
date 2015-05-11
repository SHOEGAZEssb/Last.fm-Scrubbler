# Scrubbler
Manual last.fm scrobbling, for when a service (or you!) failed to scrobble.

# Features
- Scrobble any track!
- Scrobble to the past! (Up to two weeks)
- Set track name, artist name, album name, date and time! 

# Building
If you want to build the solution you have to add ```https://ci.appveyor.com/nuget/lastfm-ql51ic53xoqw``` to your NuGet package sources, and install the ```IF.Lastfm.Core``` prerelease package.

Additionally, you need to have Nuget's ```Package Restore``` activated, otherwise you'll have to add the missing packages manually.
