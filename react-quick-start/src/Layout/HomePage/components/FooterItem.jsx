let now = new Date();
const FooterItem = () => {
    return (
        <p className='m-3'>&copy; Авторские права мои {now.getUTCFullYear()}</p>
    )
}

export default FooterItem;