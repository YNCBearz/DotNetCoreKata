// import necessary modules
import { check } from 'k6';
import http from 'k6/http';

// define configuration
export const options = {
    // define thresholds
    thresholds: {
        http_req_failed: ['rate<0.01'], // http errors should be less than 1%
        http_req_duration: ['p(95)<6000'], // 95% of requests should be below 6s
    },
};

export default function () {
    // define URL and request body
    const url = 'http://localhost:5037/api/age-of-empires/unit/1';
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