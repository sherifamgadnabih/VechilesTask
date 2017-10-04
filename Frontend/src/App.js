import React, { Component } from 'react';
import { LoadVechiles } from './actions/index'
import { connect } from 'react-redux'
import logo from './logo.svg';
import './App.css';
import VechilesGrid from './components/vechilesGrid'
import 'bootstrap/dist/css/bootstrap.min.css'

class App extends Component {
  componentDidMount() {
    let { dispatch } = this.props;
    dispatch(LoadVechiles());
  }
  render() {
    let { vechiles } = this.props



    return (
      <div className="App">
        <header className="App-header">
          <h1 className="App-title">Vechiles</h1>
        </header>
        <VechilesGrid vechiles={vechiles} />
      </div>
    );
  }
}
function mapDispatchToProps(dispatch) {
  return {
    dispatch
  }
}
function mapStateToProps(state) {
  return {
    vechiles: state.vechiles
  }
}
export default connect(mapStateToProps, mapDispatchToProps)(App);
