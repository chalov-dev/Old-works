import requests
import datetime as dt


def current_time(city):
    offset = dt.timedelta(hours=UTC_OFFSET[city])
    result = dt.datetime.utcnow() + offset
    return result.strftime('%H:%M')


def handler_requests(city):
    url = 'http://wttr.in/' + CITY[city]
    param_weather = {
        'lang': 'ru',
        'T': '',
        '0': ''
    }
    response = requests.get(url, params=param_weather)
    weather = response.text
    return weather


def decor_weather(func):
    def wrapper(l):
        print(f'Погода на данный момент:')
        func(l)

    return wrapper


@decor_weather
def format_weather(weather):
    l = weather.split('\n')
    for i in l[2:]:
        print(i)


def current_data(data):
    offset = dt.timedelta(hours=UTC_OFFSET[data])
    result = dt.datetime.utcnow() + offset
    return result.strftime('%d %B %Yг, %A')


CITY = {
    'Москва': 'Moscow',
    'Владивосток': 'Vladivostok'
}

UTC_OFFSET = {
    'Москва': 3,
    'Владивосток': 10
}
x = input('Введите название города: ')
if x in CITY and x in UTC_OFFSET:
    print(f'Город: {x}')
    print(f'Текущее время: {current_time(x)}')
    print(f'Дата: {current_data(x)}')
    result_handler = handler_requests(x)
    result_weather = format_weather(result_handler)


