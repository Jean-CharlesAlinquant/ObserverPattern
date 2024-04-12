using DesignPatterns.Observer;

WeatherStation weatherStation = new WeatherStation();

NewsAgency agency1 = new NewsAgency("ABC News");
weatherStation.Attach(agency1);

NewsAgency agency2 = new NewsAgency("BBC News");
weatherStation.Attach(agency2);

NewsAgency agency3 = new NewsAgency("RTE News");
weatherStation.Attach(agency3);

weatherStation.Temperature = 31.2f;
weatherStation.Temperature = 28f;
weatherStation.Temperature = 46.8f;
weatherStation.Temperature = 15.3f;