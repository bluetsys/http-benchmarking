<Query Kind="Statements">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var _Count = 1000;

var _List = new Model[] {
	new Model { IsDocker = true, Count = _Count, Port = 8001, Language =  "dotnet", Description = "run" },
	new Model { IsDocker = true,Count = _Count, Port = 8002, Language =  "python", Description = "django" },
	new Model { IsDocker = true,Count = _Count, Port = 8003, Language =  "python", Description = "fastapi" },
	new Model { IsDocker = true,Count = _Count, Port = 8004, Language =  "python", Description = "flask" },
	new Model { IsDocker = true,Count = _Count, Port = 8005, Language =  "node", Description = "express" },
	new Model { IsDocker = true,Count = _Count, Port = 8006, Language =  "node", Description = "http" },
	new Model { IsDocker = true,Count = _Count, Port = 8007, Language =  "java", Description = "spring" },

	new Model { IsDocker = false,Count = _Count, Port = 8080, Language =  "java", Description = "spring" },
	new Model { IsDocker = false,Count = _Count, Port = 8021, Language =  "dotnet", Description = "iis" },
	new Model { IsDocker = false,Count = _Count, Port = 8011, Language =  "dotnet", Description = "run" },
	//new Model { IsDocker = false,Count = _Count, Port = 8012, Language =  "python", Description = "django" },
	//new Model { IsDocker = false,Count = _Count, Port = 8013, Language =  "python", Description = "fastapi" },
	//new Model { IsDocker = false,Count = _Count, Port = 8014, Language =  "python", Description = "flask" },
	//new Model { IsDocker = false,Count = _Count, Port = 8015, Language =  "node", Description = "express" },
	//new Model { IsDocker = false,Count = _Count, Port = 8016, Language =  "node", Description = "http" },
	new Model { IsDocker = false,Count = _Count, Port = 8017, Language =  "dotnet", Description = "http" },
};

foreach (var _Model in _List)
{
	var eee = new System.Net.Http.HttpClient();
	eee.GetAsync($"http://127.0.0.1:{_Model.Port}").Result.Content.ReadAsStringAsync();
	_Model.Start();
	var _Item = new List<string>();
	for (int i = 0; i < _Model.Count; i++)
	{
		_Item.Add(eee.GetAsync($"http://127.0.0.1:{_Model.Port}").Result.Content.ReadAsStringAsync().Result);
	}

	_Model.AddData(_Item.ToArray());
	_Model.Stop();
}

_List.OrderBy(r => r.ElapsedTicks).Dump();

class Model
{
	public string Language { get; set; }
	public string Description { get; set; }
	public bool IsDocker { get; set; }
	public int Count { get; set; }
	public int Port { get; set; }

	private Stopwatch Stopwatch = new Stopwatch();

	public TimeSpan Elapsed => this.Stopwatch.Elapsed;

	public long ElapsedTicks => this.Stopwatch.ElapsedTicks;
	public long ElapsedMilliseconds => this.Stopwatch.ElapsedMilliseconds;

	public string CountSeconds => this.CountSecondsValue.ToString("#,##");
	public string CountMinutes => this.CountMinutesValue.ToString("#,##");

	private double CountSecondsValue => (this.Count / this.Stopwatch.ElapsedTicks) * 1000;
	private double CountMinutesValue => CountSecondsValue * 60;

	public void Start() => this.Stopwatch.Start();
	public void Stop() => this.Stopwatch.Stop();

	public string Value => this.Values.FirstOrDefault();
	private string[] Values { get; set; }

	public void AddData(string[] list)
	{
		this.Values = list.Distinct().Select(r => r).ToArray();
	}
}