const express = require('express');
const task = require('./task');

const app = express();

app.use(express.json());

// maybe delete this, i tested it on localhost
app.use((req, res, next) => {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Headers', 'origin, content-type, accept');
    res.setHeader("Access-Control-Allow-Methods", "*");
    next();
});

app.post('/', (req, res) => {
    console.log('request matrix', req.body);
    try {
        const result = task.calculate(req.body);
        console.log("answer: ", result);
        if (result) {
            return res.status(200).json(JSON.stringify(result));
        }
        return res.status(404);
    } catch (e) {
        console.log(e);
        return res.status(500).json({'idk': 'what'});
    }
});

app.listen(3000, '0.0.0.0', () => { console.log('Server start at 3000') })