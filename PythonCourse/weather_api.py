import requests
city = input('Type what city you want the weather for\n')
url = "http://api.weatherapi.com/v1/current.json?key=ab3b23d9d9954f7a8dd224223232405&q=" + city + "&aqi=no"
response = requests.get(url)
weather_json = response.json()

location = weather_json.get('location').get('name')
temp = weather_json.get('current').get('temp_c')
description = weather_json.get('current').get('condition').get('text')
print("Today's weather in", location, "is", description, 'and', temp, 'C')