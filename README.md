# GPLACES-API

## Project Info
* This dotnet core application houses HTTP GET Request APIs that are then forwarded to the Google Places APIs
* Get Request Handlers are housed in the Controllers Directory under: **[Controllers/DetailsController.cs](Controllers/DetailsController.cs)** & **[Controllers/PlacesController.cs](Controllers/PlacesController.cs)**
* The web clients that hit Google's APIs are in: **[Controllers/DetailsCaller.cs](Controllers/DetailsCaller.cs)** & **[Controllers/PlacesCaller.cs](Controllers/PlacesCaller.cs)**

---

## .NET Core App Info
* Restore app: ``` dotnet restore ```
* Run app: ``` dotnet run ```
* Call API in development (HTTP GET Request):
    * Places Search: http://localhost:5000/places/SEARCH_TERM_HERE
    * Places Details: http://localhost:5000/details/PLACE_ID_HERE
* Publish app for Linux Release: ``` dotnet publish -c Release --self-contained -r linux-x64 --framework netcoreapp2.1 ```
    * For windows use: ``` win-x64 ``` instead of: ``` linux-x64 ```
* Build docker image: ``` docker build . -t gplaces-api:latest ```
* Run the docker image: ``` docker run -d --name gplaces-api -p 8080:80 --restart unless-stopped gplaces-api:latest ```

---

## Google API Reference
* [Google Places Search](https://developers.google.com/places/web-service/search)
* [Google Places Details](https://developers.google.com/places/web-service/details)