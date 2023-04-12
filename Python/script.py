#----------------------------#
# Importar dependencias
#----------------------------#
import datetime
import re

#----------------------------#
# Utilidades
#----------------------------#
events = {
    "1": {
        "date": str(datetime.datetime.today().strftime('%d/%m/%y')),
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 1",
        "time": "10:00 AM",
        "comments": "Aun no hay comentarios"
        },
    "2": {
        "date": "18/03/2023",
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 2",
        "time": "11:00 AM",
        "comments": "Aun no hay comentarios"
        },
    "3": {
        "date": "18/03/2023",
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 3",
        "time": "12:00 AM",
        "comments": "Aun no hay comentarios"
        },
}

#------------------------------------------------------------------------------#

#----------------------------#
# Prueba importar dependencias
#----------------------------#
def import_dependencies():
    try:
        import datetime
        import re
        return "Dependecias importadas"
    except ImportError as e:
        exception = ("Error: {0}".format(e))
        return exception

#----------------------------#
# Ejecutar
#----------------------------#
def get_data(answer):
    answer.lower()

    # Muestra todos los eventos
    if "todos" in answer:
        return '1'
    else:
        return '0'

#----------------------------#
# Mostrar todos los eventos
#----------------------------#
def set_all_events():
    return events