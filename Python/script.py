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
        "date": str(datetime.datetime.today().strftime('%d/%m/%Y')),
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 1",
        "time": "10:00 AM",
        "comments": "Aun no hay comentarios"
        },
    "2": {
        "date": str(datetime.datetime.today().strftime('%d/%m/%Y')),
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 2",
        "time": "11:00 AM",
        "comments": "Aun no hay comentarios"
        },
    "3": {
        "date": str(datetime.datetime.today().strftime('%d/%m/%Y')),
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 3",
        "time": "12:00 AM",
        "comments": "Aun no hay comentarios"
        },
    "4": {
        "date": str(datetime.datetime.today().strftime('%d/%m/%Y')),
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 4",
        "time": "01:00 PM",
        "comments": "Aun no hay comentarios"
        },
    "5": {
        "date": str(datetime.datetime.today().strftime('%d/%m/%Y')),
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 5",
        "time": "02:00 PM",
        "comments": "Aun no hay comentarios"
        },
    "6": {
        "date": "23/04/2023",
        "title": "Conferencia de tecnologia",
        "description": "Conferencia sobre tecnologia de punta",
        "location": "Sala de conferencias 6",
        "time": "03:00 PM",
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

#----------------------------#
# Mostrar todos los eventos de hoy
#----------------------------#
def set_today_events():
    today = str(datetime.datetime.today().strftime('%d/%m/%y'))
    today_events = {}

    for key in events:
        if events[key]['date'] == today:
            today_events[key] = events[key]

    return today_events

#----------------------------#
# Mostrar todos los eventos de una fecha
#----------------------------#
def set_date_events(date_str):
    patron = r"\d{1,2}/\d{1,2}/\d{4}"
    match = re.search(patron, date_str)

    if match:
        date = match.group() 

    else:
        date = ""

    events_date = {}

    for event_id, event in events.items():
        if event['date'] == date:
            events_date[event_id] = event

    if not events_date:
        return "No hay eventos en la fecha especificada."
    else:
        return events_date

#----------------------------#
# Agregar un nuevo evento al diccionario events
#----------------------------#
def add_event_to_events(date, title, description, location, time, comments):
    new_event_id = str(len(events) + 1)
    
    new_event = {
        "date": date,
        "title": title,
        "description": description,
        "location": location,
        "time": time,
        "comments": comments
    }
    
    events[new_event_id] = new_event
    print(events)
    return "Evento agregado correctamente"

#----------------------------#
# Agregar un nuevo comentario al diccionario events
#----------------------------#
def add_comment(title, comment):
    if title in events:
        events[title]['comments'].append(comment)
        return "Comentario agregado correctamente"
    else:
        return "No existe un evento con ese titulo"