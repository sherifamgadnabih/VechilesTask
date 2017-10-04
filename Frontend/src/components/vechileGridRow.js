import React, { Component } from 'react';

class VechilesRow extends Component {
    render() {
        let {CustomerName, CustomerAddress, VIN, RegNr, Status} =  this.props.vechile ;
        return (
            <tr>
                <td>{CustomerName} </td>
                <td>{CustomerAddress} </td>
                <td>{VIN} </td>
                <td> {RegNr} </td>
                <td> {Status?'Yes':'No'} </td>
            </tr>
        )
    }
}
export default VechilesRow