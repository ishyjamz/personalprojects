current_movies = {'Meow Cat': '11:00am',
                  'Steven Cat': '12:00pm',
                  'Showboat Time':'8:00pm'}

print('Currently showing following movies:')
for key in current_movies:
    print(key)

movie = input('What movie would you like the showtime for? \n')

showtime = current_movies.get(movie)

if showtime:
    print('movie showing at', showtime)
else:
    print('nah mate')