import React, { Component } from 'react';
import VechileRow from './vechileGridRow'
class VechilesGrid extends Component {

    render() {
        let { vechiles } = this.props.vechiles;
        let vechilesRows = [];
        if (vechiles) {
                vechiles.forEach(function (arrayItem) {
                    vechilesRows.push(<VechileRow vechile={arrayItem} />)
                });
            
        }
        return (
            <table className="table table-stripped">
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