import fetch from 'isomorphic-fetch'
import { baseURL } from '../constants/index'
export const Load_Vechiles = 'Load_Vechiles'
export const Recieve_Vechiles = 'Recieve_Vechiles'
export function LoadVechiles() {
    let url = baseURL + 'vechiles'
    return function (dispatch) {
        return fetch(url).then(
            response => response.json(),
        ).then(json => {

            dispatch(recieveVechiles(json))

        }


            )
    }
}
function recieveVechiles(vechiles) {
    return {
        type: Recieve_Vechiles,
        vechiles
    }
}