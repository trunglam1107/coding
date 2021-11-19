import './App.css';
import React from 'react';

class App extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            header:"Header from state",
            content: "Content from state"
        }
    }

    render() {
        return (
            <div>
                <Header headerProp={this.state.header}></Header>
                <Content contentProp={this.state.content}></Content>
            </div>
        );
    }
}

class Header extends React.Component {
    render() {
        return (
            <div>
                <h1>{this.props.headerProp}</h1>
            </div>
        );
    }
}

class Content extends React.Component {
    render() {
        return (
            <div>
                <h1>{this.props.contentProp}</h1>
            </div>
        );
    }
}

export default App;