// import necessary modules
import {check} from 'k6';
import http from 'k6/http';

const myDurationMin = (60 / 60);
const myTimes = 2;

// define configuration
export const options = {
    // define thresholds
    thresholds: {
        http_req_failed: ['rate<0.01'], // http errors should be less than 1%
        http_req_duration: ['p(95)<6000'], // 95% of requests should be below 6s
    },
    // define stages
    scenarios: (() => {
        const myScenarios = [
            {
                exec: 'createMilitia',
                tpm: 10,
                vus: 1,
            },
            {
                exec: 'createArcher',
                tpm: 10,
                vus: 1,
            },
            {
                exec: 'createKnight',
                tpm: 10,
                vus: 1,
            },
        ];

        return myScenarios.reduce((acc, scenario) => {
            acc[scenario.exec] = {
                executor: "per-vu-iterations",
                exec: scenario.exec,
                vus: scenario.vus,
                iterations: Math.ceil(scenario.tpm * myDurationMin / scenario.vus * myTimes),
                maxDuration: myDurationMin + 'm',
            };
            return acc;
        }, {});
    })(),
};

export function createMilitia() {
    // define URL and request body
    const url = 'http://localhost:5037/api/age-of-empires/unit/1';
    const payload = JSON.stringify({});
    const params = {
        headers: {
            'Content-Type': 'application/json',
        },
    };

    // send a post request and save response as a variable
    const res = http.post(url, payload, params);

    // check that response is 200
    check(res, {
        'response code was 200': (res) => res.status === 200,
    });
}

export function createArcher () {
    // define URL and request body
    const url = 'http://localhost:5037/api/age-of-empires/unit/2';
    const payload = JSON.stringify({
    });
    const params = {
        headers: {
            'Content-Type': 'application/json',
        },
    };

    // send a post request and save response as a variable
    const res = http.post(url, payload, params);

    // check that response is 200
    check(res, {
        'response code was 200': (res) => res.status === 200,
    });
}
export function createKnight () {
    // define URL and request body
    const url = 'http://localhost:5037/api/age-of-empires/unit/3';
    const payload = JSON.stringify({
    });
    const params = {
        headers: {
            'Content-Type': 'application/json',
        },
    };

    // send a post request and save response as a variable
    const res = http.post(url, payload, params);

    // check that response is 200
    check(res, {
        'response code was 200': (res) => res.status === 200,
    });
}
