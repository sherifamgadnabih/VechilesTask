import React, { Component } from 'react';

class VechilesRow extends Component {
    render() {
        let {CustomerName, CustomerAddress, VIN, RegR, Status} =  this.props.vechile ;
        return (
            <tr>
                <td>{CustomerName} </td>
                <td>{CustomerAddress} </td>
                <td>{VIN} </td>
                <td> {RegR} </td>
                <td> {Status} </td>
            </tr>
        )
    }
}
export default VechilesRow