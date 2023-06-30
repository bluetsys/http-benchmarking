import platform
import sys
import django

from django.conf import settings
from django.urls import path
from django.http import HttpResponse
from django.http import JsonResponse

settings.configure(
	DEBUG=True,  # For debugging
	#SECRET_KEY="a-bad-secret",  # Insecure! change this
	ROOT_URLCONF=__name__,
)

def home(request):
	return HttpResponse("Hello World")

def health(request):

	data = {
        "hostname":  platform.node(),
        "language":
        {
            "name": 'python',
            "version": platform.python_version(),
        },
        "web":
        {
            "name": 'django',
            "version": django.__version__,
        },
    }

	return JsonResponse(data)

urlpatterns = [
	path("", home),
	path("health", health),
]

if __name__ == "__main__":
	from django.core.management import execute_from_command_line

	execute_from_command_line(sys.argv)