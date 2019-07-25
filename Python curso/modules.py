# own modules
# thirdy party modules
# python modules

# se puede googlear los modulos de python
import datetime
from fmath import add,substract
from colorama import Fore,Style,init

print(datetime.date.today())
print(datetime.timedelta(minutes=70))

# se puede poner: from datetime import timedelta
# y poner: print(timedelta(minutes=70))

#se pueden agregar mas: from datetime import timedelta, date

add(2,4)
substract(3,1)

init(convert=True)
print(Fore.RED + "Hello World")