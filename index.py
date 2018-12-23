import requests
import json
import numpy as np

class MyEncoder(json.JSONEncoder):
    def default(self, obj):
        if isinstance(obj, np.ndarray):
            return obj.tolist()
        elif isinstance(obj, bytes):
            return str(obj, encoding='utf-8');
        return json.JSONEncoder.default(self, obj)



if __name__=="__main__":
    headers={'API-key':'NWBW5KGYG3SQ7X5YUHIMHJNCWNF44P7PYW2A'}
    rep=requests.get("https://api.vultr.com/v1/server/list",headers=headers)
    print(json.dumps(rep.content,cls=MyEncoder,indent=2))