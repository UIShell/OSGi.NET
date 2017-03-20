namespace OSGi.NET.Core
{
    /// <summary>
    /// Bundle激活器
    /// </summary>
    public interface IBundleActivator
    {
        /// <summary>
        /// 激活器启动
        /// </summary>
        /// <param name="context"></param>
        void Start(IBundleContext context);

        /// <summary>
        /// 激活器停止
        /// </summary>
        /// <param name="context"></param>
        void Stop(IBundleContext context);
    }
}
