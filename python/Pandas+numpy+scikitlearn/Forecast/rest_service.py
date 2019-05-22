from flask import Flask, make_response, request
import forecasting
app = Flask(__name__)

@app.route('/', methods=['POST'])
def get_forecast():
    fc = forecasting.Forecasting(request.json, model_path="model.sav")
    resp = make_response(fc.forecast_for_dataset(),200)
    resp.headers['Content-Type'] = 'text/json'
    return resp

if __name__ == '__main__':
    app.run(debug=True)
