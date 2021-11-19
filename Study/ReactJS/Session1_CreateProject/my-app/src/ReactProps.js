import './App.css';
import React from 'react';

class Props extends React.Component {
    render() {
        return (
            <div>
                <h1>{this.props.headerProps}</h1>
                <h1>{this.props.contentProps}</h1>
            </div>
        );
    }
}

Props.defaultProps = {
    headerProps:"Default Header  Props ....",
    contentProps:"Default Content Props"
}

export default Props;