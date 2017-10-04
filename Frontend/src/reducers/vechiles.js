import { Load_Vechiles, Recieve_Vechiles } from '../actions/index'
const initialState = {
    vechiles: []
}
export function Vechiles(state = initialState, action) {
    switch (action.type) {
        case Load_Vechiles:
            return state;
        case Recieve_Vechiles:
            return Object.assign({}, action.vechiles)
        default:
            return state;
    }
}