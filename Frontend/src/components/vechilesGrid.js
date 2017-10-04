import React, { Component } from 'react';
import VechileRow from './vechileGridRow'
class VechilesGrid extends Component {

    render() {
        let { vechiles } = this.props;
        let vechilesRows = [];
        if (vechiles) {
            for (var i = 0; i < vechiles.length; i++) {
                vechilesRows.push(<VechileRow Vechile={vechiles[i]} />)
            }
        }
        return (
            <table>
                <thead>
                    <tr>
                    <th> Customer Name </th>
                    <th> Customer Address </th>
                    <th> Vechile ID </th>
                    <th> Registration Number </th>
                    <th> Connected </th>
                    </tr>
                </thead>
                <tbody>
                    {vechilesRows}
                </tbody>
            </table>
        )
    }
}

export default VechilesGrid